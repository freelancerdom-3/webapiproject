using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.BL.ServiceAreaMapping;
using ENT.Model.Common;
using ENT.Model.EntityFramework;
using ENT.Model.ServiceProviderAreaMapping;
using Microsoft.EntityFrameworkCore;

namespace ENT.BL.ServiceProviderAreaMapping
{

    public class ServiceProviderAreaMapping : IServiceProviderAreMapping
    {
        private readonly MyDBContext _context;

        public ServiceProviderAreaMapping(MyDBContext context)
        {
            _context = context;
        }
        public async Task<APIResponseModel> Add(ServiceProviderAreaMappingModel objServiceProviderAreaMapping)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    await connection.TblServiceProviderAreaMapping.AddAsync(objServiceProviderAreaMapping);
                    await connection.SaveChangesAsync();
                }
                response.Data = true;
                response.statusCode = 201;
                return response;
            }
            catch (Exception ex)
            {
                response.statusCode = 400;
                response.Data = false;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<APIResponseModel> Delete(int MappingId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    bool objectExists = await connection.TblServiceProviderAreaMapping.AnyAsync(x => x.MappingId == MappingId);
                    if (objectExists)
                    {
                        var deleteObject = await connection.TblServiceProviderAreaMapping.FirstAsync(x => x.MappingId == MappingId);

                        connection.TblServiceProviderAreaMapping.Remove(deleteObject);
                        await connection.SaveChangesAsync();

                        response.Data = true;
                        response.Message = "Data deleted successfully";
                    }
                    else
                    {
                        response.Data = false;
                        response.Message = "Id " + MappingId + " does not exists";
                    }
                    response.statusCode = 200;
                }
                return response;
            }
            catch (Exception ex)
            {
                response.statusCode = 400;
                response.Data = false;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<APIResponseModel> GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    response.Data = await _context.TblServiceProviderAreaMapping.ToListAsync();
                }
                response.statusCode = 200;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 404;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<APIResponseModel> GetById(int MappingId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {

                using (MyDBContext connection = _context)
                {
                    bool objectExists = await connection.TblServiceProviderAreaMapping.AnyAsync(x => x.MappingId == MappingId);
                    if (objectExists)
                    {
                        response.Data = await connection.TblServiceProviderAreaMapping.Where(x => x.MappingId == MappingId).FirstAsync();
                        response.Message = "Data get successfully";
                    }
                    else
                    {
                        response.Message = "Id " + MappingId + " does not exists";
                    }
                }
                response.statusCode = 200;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.Message = ex.Message;
                response.statusCode = 400;
                return response;
            }
        }

        public async Task<APIResponseModel> Update(ServiceProviderAreaMappingModel objServiceProviderAreaMapping)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    bool objectExists = await connection.TblServiceProviderAreaMapping.AnyAsync(x => x.MappingId == objServiceProviderAreaMapping.MappingId);
                    if (objectExists)
                    {
                        connection.Update(objServiceProviderAreaMapping);
                        await connection.SaveChangesAsync();
                        response.Message = "Data updated successfully";
                    }
                    else
                    {
                        response.Message = "Given object does not exists";
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
