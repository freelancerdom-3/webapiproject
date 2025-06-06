using ENT.Model.Common;
using ENT.Model.CustomModel;
using ENT.Model.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.ServiceProviderSubCategoryMapping
{
    public class ServiceProviderSubCategoryMapping : IServiceProviderSubCategoryMapping
    {
        private readonly MyDBContext _context;
        public ServiceProviderSubCategoryMapping(MyDBContext context)
        {
            _context = context;
        }
        public async Task<APIResponseModel> GetByArea(string areaName)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                List<ServiceProviderSubCategoryMappingViewModel> searchResults = new();
                using (MyDBContext connection = _context)
                {
                    searchResults = await connection.ServiceProviderSubCategoryMappingViewModel.FromSqlRaw( $@"                                      
                         SELECT DISTINCT 
                        users.UserId AS UserId, 
                        users.FullName AS FullName, 
                        sc.SubCategoryName AS SubCategoryName
                        FROM TblAreas areas
                        JOIN TblServiceProviderAreaMapping spareamap 
                        ON areas.AreaId = spareamap.AreaId
                        JOIN TblUsers users 
                        ON spareamap.UserId = users.UserId
                        JOIN TblServiceProviderSubCategoryMapping spscmap 
                        ON users.UserId = spscmap.UserId
                        JOIN TblSubCategorys sc 
                        ON spscmap.SubcategoryId = sc.SubCategoryId
                        WHERE users.UserTypeId = 3 
                        AND areas.AreaName LIKE '{areaName}%';
                        ").AsNoTracking().ToListAsync();
           
                }
                

                if (searchResults.Count() == 0)
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
                response.Data = false;
                return response;
            }
        }

        public async Task<APIResponseModel> GetBySubCategoryName(string SubCategoryName)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                List<ServiceProviderSubCategoryMappingViewModel> searchResults = new();
                using (MyDBContext connection = _context)
                {
                    searchResults = await connection.ServiceProviderSubCategoryMappingViewModel.FromSqlRaw($@"
                     SELECT users.UserId AS UserId, users.FullName AS FullName, sc.SubCategoryName AS SubCategoryName
                    from TblSubCategorys sc
                        JOIN TblServiceProviderSubCategoryMapping spscmap
                        ON sc.SubCategoryId = spscmap.SubCategoryId
                        JOIN TblUsers users
                        ON spscmap.UserId = users.UserId
                        WHERE sc.SubCategoryName LIKE  '{SubCategoryName}%'").ToListAsync();

                }
                if (searchResults.Count() == 0)
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
                response.Data = false;
                return response;
            }
        }



    }
}
