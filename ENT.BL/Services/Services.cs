using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.BL.Category;
using ENT.Model.Common;
using ENT.Model.EntityFramework;
using ENT.Model.Services;
using Microsoft.EntityFrameworkCore;

namespace ENT.BL.Services
{
    public class Services : IServices
    {
        private readonly MyDBContext _context;
        public Services(MyDBContext context)
        {
            _context = context;
        }
        public async Task<APIResponseModel> Add(ServicesModel objServices)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    bool isDuplicate = await _context.TblServices.AnyAsync(x => x.SubCategoryId == objServices.SubCategoryId 
                                                                            && x.ServiceName == objServices.ServiceName);

                    if (isDuplicate)
                    {
                        response.Data = false;
                        response.statusCode = 409;
                        response.Message = "Service with same name already exists";
                        return response;
                    }
                    await _context.TblServices.AddAsync(objServices);
                    await _context.SaveChangesAsync();

                    response.Data = true;
                    response.statusCode = 200;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
                
            }
        }

        public async Task<APIResponseModel> Delete(int ServiceId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    var service = await _context.TblServices.FirstOrDefaultAsync(x => x.ServiceId == ServiceId);

                    if (service != null)
                    {
                        _context.TblServices.Remove(service);
                        await _context.SaveChangesAsync();

                        response.statusCode = 200;
                        response.Message = "service deleted successfully.";
                    }
                    else
                    {
                        response.Data = false;
                        response.statusCode = 404;
                        response.Message = "service not found.";
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
                throw;
            }
        }

        public async Task<APIResponseModel> GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                List<ServicesModel> listOfServices = new List<ServicesModel>();
                using (var connection = _context)
                {
                    listOfServices = await connection.TblServices.ToListAsync();

                    response.statusCode = 200;
                    response.Data = listOfServices;
                    
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
               
            }
        }

        public async Task<APIResponseModel> GetByName(string serviceName, string? regionType, int? regionId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    if (regionType != null && regionType.Equals("Area"))
                    {

                        response.Data = await connection.ServicesBySearchViewModel
                        .FromSqlRaw($@"SELECT sc.SubCategoryName AS Name, sc.SubCategoryId AS Id, 'SubCategory' AS Type, NULL AS Parent
                            FROM TblSubCategorys sc
                            WHERE sc.SubCategoryName LIKE '%{serviceName}%'

                            UNION

                            SELECT se.ServiceName AS Name, se.ServiceId AS Id, 'Service' AS Type, sc.SubCategoryName AS parent
                            FROM TblSubCategorys sc
                            JOIN TblServices se
                            ON sc.SubCategoryId = se.SubCategoryId
                            JOIN TblServiceAreaMappings sam
                            ON sam.ServiceId = se.ServiceId
                            JOIN TblAreas a
                            ON a.AreaId = sam.AreaId
                            WHERE se.ServiceName LIKE '%{serviceName}%'
                            AND a.AreaId = {regionId};

                        ")
                        .ToListAsync();
                    }
                    else
                    {
                        response.Data = await connection.ServicesBySearchViewModel
                        .FromSqlRaw($@"SELECT sc.SubCategoryName AS Name, sc.SubCategoryId AS Id, 'SubCategory' AS Type, NULL AS Parent
                        FROM TblSubCategorys sc
                        WHERE sc.SubCategoryName LIKE '%{serviceName}%'

                        UNION

                        SELECT se.ServiceName AS Name, se.ServiceId AS Id, 'Service' AS Type, sc.SubCategoryName AS parent
                        FROM TblSubCategorys sc
                        JOIN TblServices se
                        ON sc.SubCategoryId = se.SubCategoryId
                        WHERE se.ServiceName LIKE '%{serviceName}%';
                        ")
                        .ToListAsync();
                    }
                }
                response.statusCode = 200;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
                
            }
        }

        public async Task<APIResponseModel> Update(ServicesModel objServices)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var context = _context)
                {
                    bool isDuplicate = await context.TblServices.AnyAsync(x => x.ServiceId != objServices.ServiceId && x.SubCategoryId == objServices.SubCategoryId
                                                                                                                    && x.ServiceName == objServices.ServiceName);
                    if (isDuplicate)
                    {
                        response.Data = false;
                        response.statusCode = 409;
                        response.Message = "Cannot update as given data exists";
                        return response;
                    }
                    else
                    {
                        var existingService = await context.TblServices.FirstOrDefaultAsync(x => x.ServiceId == objServices.ServiceId);
                        if (existingService != null)
                        {
                            existingService.ServiceName = objServices.ServiceName;
                            existingService.SubCategoryId = objServices.SubCategoryId;
                            existingService.Price = objServices.Price;
                            existingService.TimeTaken = objServices.TimeTaken;

                            await context.SaveChangesAsync();
                            response.statusCode = 200;
                            response.Message = "Service updated successfully.";
                        }
                        else
                        {
                            response.statusCode = 404;
                            response.Message = "Service not found.";
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 500;
                response.Message = ex.Message;
                return response;
                
            }
        }

        public async Task<APIResponseModel> GetBySubCategoryId(int id, string type)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                List<ServicesModel> servicesList = new List<ServicesModel>();
                using (var connection = _context)
                {
                    int subCategoryId = id;
                    if (type.Equals("Service"))
                    {
                        subCategoryId = await connection.TblServices.Where(x => x.ServiceId == id).Select(x => x.MainSubCategoryId).FirstAsync();
                    }
                    servicesList = await connection.TblServices.Where(x => x.MainSubCategoryId == subCategoryId).ToListAsync();
                    
                    if (servicesList.Count == 0)
                    {
                        response.Data = false;
                        response.statusCode = 204;
                        response.Message = "No services found";
                    }
                    else
                    {
                        response.Data = servicesList;
                        response.statusCode = 200;
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                response.statusCode = 400;
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }
    }
}
