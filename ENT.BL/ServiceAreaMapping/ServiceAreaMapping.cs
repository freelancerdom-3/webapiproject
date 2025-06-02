using Azure;
using ENT.Model.Common;
using ENT.Model.CustomModel;
using ENT.Model.EntityFramework;
using ENT.Model.ServiceAreaMapping;
using ENT.Model.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.ServiceAreaMapping
{
    public class ServiceAreaMapping : IServiceAreaMapping
    {
        private readonly MyDBContext _context;

        public ServiceAreaMapping(MyDBContext context)
        {
            _context = context;
        }
        public async Task<APIResponseModel> Add(ServiceAreaMappingModel objServiceAreaMapping)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    await connection.TblServiceAreaMappings.AddAsync(objServiceAreaMapping);
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

        public async Task<APIResponseModel> Delete(int serviceAreaMappingId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    bool objectExists = await connection.TblServiceAreaMappings.AnyAsync(x => x.MappingId == serviceAreaMappingId);
                    if (objectExists)
                    {
                        var deleteObject = await connection.TblServiceAreaMappings.FirstAsync(x => x.MappingId == serviceAreaMappingId);

                        connection.TblServiceAreaMappings.Remove(deleteObject);
                        await connection.SaveChangesAsync();

                        response.Data = true;
                        response.Message = "Data deleted successfully";
                    }
                    else
                    {
                        response.Data = false;
                        response.Message = "Id " + serviceAreaMappingId + " does not exists";
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
                    response.Data = await _context.TblServiceAreaMappings.ToListAsync();
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

        public async Task<APIResponseModel> GetById(int serviceAreaMappingId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {

                using (MyDBContext connection = _context)
                {
                    bool objectExists = await connection.TblServiceAreaMappings.AnyAsync(x => x.MappingId == serviceAreaMappingId);
                    if (objectExists)
                    {
                        response.Data = await connection.TblServiceAreaMappings.Where(x => x.MappingId == serviceAreaMappingId).FirstAsync();
                        response.Message = "Data inserted successfully";
                    }
                    else
                    {
                        response.Message = "Id " + serviceAreaMappingId + " does not exists";
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


        public async Task<APIResponseModel> Update(ServiceAreaMappingModel objServiceAreaMapping)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    bool objectExists = await connection.TblServiceAreaMappings.AnyAsync(x => x.MappingId == objServiceAreaMapping.MappingId);
                    if (objectExists)
                    {
                        connection.Update(objServiceAreaMapping);
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

        public async Task<APIResponseModel> GetAreaBySearch(string? name)
        {
            APIResponseModel response = new();
            try
            {
                List<GetAreaBySearchViewModel> searchResults = new();
                using (MyDBContext connection = _context)
                {
                    //lstUsers = string.IsNullOrEmpty(searchBy)? connection.TblUsers.ToList():
                    //    connection.TblUsers.Where(x=>x.FullName.ToLower()==searchBy.ToLower()).
                    //    ToList();

                    //            lstUsers = connection.GetTblUserViewModel.FromSqlRaw($@"SELECT tuser.*,trole.rolename 
                    //            FROM [HSMDB].[dbo].[TblUser] tuser
                    //            inner join tblrole trole on trole.roleid=tuser.roleid where RoleName like '%{searchBy}%'").ToList();

                    

                    searchResults = await connection.GetAreaBySearchViewModel.FromSqlRaw($@"
                    SELECT TOP 10
                        Id,
                        Name,
                        Type,
                        Parent
                    FROM (
                        SELECT 
                            CAST(c.CityId AS INT) AS Id,
                            c.CityName AS Name,
                            'City' AS Type,
                            CONCAT(s.StateName, ' > ', co.CountryName) AS Parent
                        FROM TblCities c
                        INNER JOIN TblStates s ON c.StateId = s.StateId
                        INNER JOIN TblCountries co ON s.CountryId = co.CountryId
                        WHERE c.CityName LIKE '{name}%'

                        UNION

                        SELECT 
                            CAST(a.AreaId AS INT) AS Id,
                            a.AreaName AS Name,
                            'Area' AS Type,
                            CONCAT(c.CityName, ' > ', s.StateName, ' > ', co.CountryName) AS Parent
                        FROM TblAreas a
                        INNER JOIN TblCities c ON a.CityId = c.CityId
                        INNER JOIN TblStates s ON c.StateId = s.StateId
                        INNER JOIN TblCountries co ON s.CountryId = co.CountryId
                        WHERE a.AreaName LIKE '{name}%'

                        UNION

                        SELECT 
                            CAST(s.StateId AS INT) AS Id,
                            s.StateName AS Name,
                            'State' AS Type,
                            co.CountryName AS Parent
                        FROM TblStates s
                        INNER JOIN TblCountries co ON s.CountryId = co.CountryId
                        WHERE s.StateName LIKE '{name}%'

                        UNION

                        SELECT 
                            CAST(co.CountryId AS INT) AS Id,
                            co.CountryName AS Name,
                            'Country' AS Type,
                            NULL AS Parent
                        FROM TblCountries co
                        WHERE co.CountryName LIKE '{name}%'
                    ) AS AllResults
                    GROUP BY Id, Name, Type, Parent
                    ").ToListAsync();
                    
                }
                if(searchResults.Count() == 0)
                {
                    response.Message = "Data does not exists";
                    response.statusCode = 204;
                }
                else
                {
                    response.Data = searchResults;
                    response.statusCode = 200;
                }
                return response;
            }
            catch (Exception ex)
            {
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<APIResponseModel> GetServicesByRegionType(string regionType, int regionId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                List<ServicesModel> serviceList = new List<ServicesModel>();
                using(MyDBContext connection = _context)
                {
                    if (regionType.Equals("Area"))
                    {
                        serviceList = await connection.TblServices.FromSqlRaw($@"
                            SELECT s.ServiceId AS ServiceId, s.ServiceName AS ServiceName, s.SubCategoryId AS SubCategoryId, s.Price AS Price, s.TimeTaken AS TimeTaken
                            FROM TblServices s
                            JOIN TblServiceAreaMappings sa
                            ON s.ServiceId = sa.ServiceId
                            WHERE sa.AreaId = '{regionId}'
                        ").ToListAsync();
                        if(serviceList.Count == 0)
                        {
                            response.Message = "Sorry we are not there yet";
                        }
                    }
                    else
                    {
                        serviceList = await connection.TblServices.ToListAsync();
                        response.Data = serviceList;
                    }
                }
                response.Data = serviceList;
                response.statusCode = 200;
                return response;
            }
            catch(Exception ex)
            {
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }
        }
    }
}
