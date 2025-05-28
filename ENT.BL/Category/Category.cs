using ENT.Model.Common;
using ENT.Model.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.EntityFramework;
using Azure;
using Microsoft.EntityFrameworkCore;

namespace ENT.BL.Category
{
    public class Category:ICategory
    {
        private readonly MyDBContext _context;
        public Category(MyDBContext context)
        {
            _context = context;
        }

        public async Task<APIResponseModel> Add(CategoryModel objCategory)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    await _context.TblCategorys.AddAsync(objCategory);
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
                throw;
            }
            
        }

        public async Task<APIResponseModel> Delete(int CategoryId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    var category = await _context.TblCategorys.FirstOrDefaultAsync(x => x.CategoryId == CategoryId);

                    if (category != null)
                    {
                        _context.TblCategorys.Remove(category); 
                        await _context.SaveChangesAsync();       

                        response.statusCode = 200;
                        response.Message = "Category deleted successfully.";
                    }
                    else
                    {
                        response.Data = false;
                        response.statusCode = 404;
                        response.Message = "Category not found.";
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
                using (var connection = _context)
                {
                    response.Data = _context.TblCategorys.ToList();
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
                throw;
            }
        }

        public async Task<APIResponseModel> GetById(int CategoryId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    response.Data = _context.TblCategorys.Where(x => x.CategoryId == CategoryId).ToList();
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
                throw;
            }
        }

        public async Task<APIResponseModel> Update(CategoryModel objCategory)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var context = _context) 
                {
                    var existingCategory = await context.TblCategorys.FirstOrDefaultAsync(x => x.CategoryId == objCategory.CategoryId);
                    if (existingCategory != null)
                    {
                        existingCategory.CategoryName = objCategory.CategoryName;
                        await context.SaveChangesAsync();
                        response.statusCode = 200;
                        response.Message = "Category updated successfully.";
                    }
                    else
                    {
                        response.statusCode = 404;
                        response.Message = "Category not found.";
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
                throw;
            }
        }

        
    }
}
