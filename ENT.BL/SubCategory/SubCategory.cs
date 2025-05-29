using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.BL.Category;
using ENT.Model.Common;
using ENT.Model.EntityFramework;
using ENT.Model.SubCategory;
using Microsoft.EntityFrameworkCore;

namespace ENT.BL.SubCategory
{
    public class SubCategory : ISubCategory
    {
        private readonly MyDBContext _context;
        public SubCategory(MyDBContext context)
        {
            _context = context;
        }
        public async Task<APIResponseModel> Add(SubCategoryModel objSubCategory)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    await _context.TblSubCategorys.AddAsync(objSubCategory);
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


        public async Task<APIResponseModel> Delete(int SubCategoryId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    var subcategory = await _context.TblSubCategorys.FirstOrDefaultAsync(x => x.SubCategoryId == SubCategoryId);

                    if (subcategory != null)
                    {
                        _context.TblSubCategorys.Remove(subcategory);
                        await _context.SaveChangesAsync();

                        response.statusCode = 200;
                        response.Message = "SubCategory deleted successfully.";
                    }
                    else
                    {
                        response.Data = false;
                        response.statusCode = 404;
                        response.Message = "SubCategory not found.";
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
                    response.Data = _context.TblSubCategorys.ToList();
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

        public async Task<APIResponseModel> GetById(int SubCategoryId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    response.Data = _context.TblSubCategorys.Where(x => x.SubCategoryId == SubCategoryId).ToList();
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

        public async Task<APIResponseModel> Update(SubCategoryModel objSubCategory)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var context = _context)
                {
                    var existingSubCategory = await context.TblSubCategorys.FirstOrDefaultAsync(x => x.SubCategoryId == objSubCategory.SubCategoryId);
                    if (existingSubCategory != null)
                    {
                        existingSubCategory.SubCategoryName = objSubCategory.SubCategoryName;
                        existingSubCategory.CategoryId = objSubCategory.CategoryId;
                        existingSubCategory.SubCategoreId = objSubCategory.SubCategoreId;
                        await context.SaveChangesAsync();
                        response.statusCode = 200;
                        response.Message = "SubCategory updated successfully.";
                    }
                    else
                    {
                        response.statusCode = 404;
                        response.Message = "SubCategory not found.";
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
