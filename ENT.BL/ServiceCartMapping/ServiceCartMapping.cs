using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.ServiceCartMapping;
using ENT.Model.Common;
using ENT.Model.EntityFramework;
using ENT.BL.Cart;
using Microsoft.EntityFrameworkCore;

namespace ENT.BL.ServiceCartMapping
{
    public class ServiceCartMapping : IServiceCartMapping
    {
        private readonly MyDBContext _context;
        public ServiceCartMapping(MyDBContext context)
        {
            _context = context;
        }
        public async Task<APIResponseModel> Add(ServiceCartMappingModel objServiceCartMapping)
        {

            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    await _context.TblServiceCartMappings.AddAsync(objServiceCartMapping);
                    await _context.SaveChangesAsync();
                }

                response.Data = true;
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

        public async Task<APIResponseModel> GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    response.Data = _context.TblServiceCartMappings.ToList();
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

        public async Task<APIResponseModel> GetById(int ServiceCartMappingId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    var cartObject = await _context.TblServiceCartMappings.Where(x => x.MappingId == ServiceCartMappingId).FirstOrDefaultAsync();
                    if (cartObject == null)
                    {
                        response.Data = "Id does not exists";
                    }
                    else
                    {
                        response.Data = cartObject;
                    }
                    await _context.SaveChangesAsync();
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

        public async Task<APIResponseModel> Update(ServiceCartMappingModel objServiceCartMapping)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    _context.TblServiceCartMappings.Update(objServiceCartMapping);
                    await _context.SaveChangesAsync();
                }

                response.Data = true;
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

        public async Task<APIResponseModel> Delete(int ServiceCartMappingId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    var deleteObject = await _context.TblServiceCartMappings.FindAsync(ServiceCartMappingId);
                    if (deleteObject == null)
                    {
                        response.Data = "id does not exists";
                    }
                    else
                    {
                        _context.TblServiceCartMappings.Remove(deleteObject);

                    }
                    await _context.SaveChangesAsync();
                }
                response.Data = true;
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
    }
}
