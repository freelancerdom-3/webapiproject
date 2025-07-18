using Azure;
using ENT.Model.Common;
using ENT.Model.CustomModel;
using ENT.Model.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.RegionSearch
{
    public class RegionSearch:IRegionSearch
    {
        private readonly MyDBContext _context;

        public RegionSearch(MyDBContext context)
        {
            _context = context;
        }

        public async Task<APIResponseModel> GetByState(string StateName)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                List<RegionNameViewModel> searchResults = new();
                using (MyDBContext connection = _context)
                {
                    response.Data = await connection.RegionNameViewModels.FromSqlRaw($@"                                      
                     SELECT st.StateId AS RegionID, st.StateName AS RegionName
                     FROM TblStates st
                     WHERE st.StateName  LIKE '{StateName}%'
                     ").ToListAsync();
                }

                //if (searchResults.Count() == 0)
                //{
                //    response.Message = "Data does not exists";
                //    response.statusCode = 204;
                //}
                //else
                //{
                //    response.Data = searchResults;
                //    response.statusCode = 200;
                //}
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


        public async Task<APIResponseModel> GetByCity(int StateId, string CityName)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                List<RegionNameViewModel> searchResults = new();
                using (MyDBContext connection = _context)
                {
                    response.Data = await connection.RegionNameViewModels.FromSqlRaw($@"                                      
                     SELECT ct.CityId AS RegionID,ct.CityName AS RegionName    
                        FROM TblCities ct
                        WHERE ct.StateId = {StateId}
                        AND ct.CityName LIKE
                        '{CityName}%'
                     ").ToListAsync();
                }

                //if (searchResults.Count() == 0)
                //{
                //    response.Message = "Data does not exists";
                //    response.statusCode = 204;
                //}
                //else
                //{
                //    response.Data = searchResults;
                //    response.statusCode = 200;
                //}
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

        public async Task<APIResponseModel> GetByArea(int CityId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                List<RegionNameViewModel> searchResults = new();
                using (MyDBContext connection = _context)
                {
                    response.Data = await connection.RegionNameViewModels.FromSqlRaw($@"                                      
                  SELECT area.AreaId AS RegionID, area.AreaName AS RegionName
                    FROM TblAreas area
                    WHERE CityId = {CityId}
                     ").ToListAsync();
                }

                //if (searchResults.Count() == 0)
                //{
                //    response.Message = "Data does not exists";
                //    response.statusCode = 204;
                //}
                //else
                //{
                //    response.Data = searchResults;
                //    response.statusCode = 200;
                //}
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
