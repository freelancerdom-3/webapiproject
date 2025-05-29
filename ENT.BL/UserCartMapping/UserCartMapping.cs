using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.UserCartMapping;
using ENT.Model.Common;
using ENT.BL.UserCartMapping;
using ENT.Model.EntityFramework;
using ENT.BL.ServiceCartMapping;
using ENT.BL.Cart;
using Microsoft.EntityFrameworkCore;

namespace ENT.BL.UserCartMapping
{
    public class UserCartMapping : IUserCartMapping
    {
        private readonly MyDBContext _context;
        public UserCartMapping(MyDBContext context)
        {
            _context = context;
        }
        public async Task<APIResponseModel> Add(UserCartMappingModel objUserCartMapping)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    await _context.TblUserCartMappings.AddAsync(objUserCartMapping);
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
                    response.Data = _context.TblUserCartMappings.ToList();
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

        public async Task<APIResponseModel> GetById(int UserCartMappingId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    var cartObject = await _context.TblUserCartMappings.Where(x => x.MappingId == UserCartMappingId).FirstOrDefaultAsync();
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

        public async Task<APIResponseModel> Update(UserCartMappingModel objUserCartMapping)
        {

            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                   var cartObject = _context.TblUserCartMappings.Update(objUserCartMapping);
                    if (cartObject == null)
                    {
                        response.Data = "Id does not Exists";
                    }
                    else
                    {
                        response.Data = cartObject;
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

        public async Task<APIResponseModel> Delete(int UserCartMappingId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    var deleteObject = await _context.TblUserCartMappings.FindAsync(UserCartMappingId);
                    if (deleteObject == null)
                    {
                        response.Data = "id does not exists";
                    }
                    else
                    {
                        _context.TblUserCartMappings.Remove(deleteObject);

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

