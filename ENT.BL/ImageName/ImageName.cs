using Azure;
using ENT.Model.Common;
using ENT.Model.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.ImageName
{
    public class ImageName : IImageName
    {
        private readonly MyDBContext _context;
        public ImageName(MyDBContext context) 
        {
            _context = context;
        }

        public async Task<APIResponseModel> GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using(var connection = _context)
                {
                    response.Data = await connection.TblImageNames.ToListAsync();
                }
                return response;
            }
            catch(Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<APIResponseModel> GetByIdAndType(int categorizedTypeId, string categorizedTypeName)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using(var connection = _context)
                {
                    response.Data = await connection.TblImageNames
                        .Where(x => x.CategorizedTypeId == categorizedTypeId && x.CategorizedTypeName.Equals(categorizedTypeName))
                        .FirstAsync();
                }
                response.statusCode = 200;
                return response;
            }
            catch(Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }
        }
    }
}
