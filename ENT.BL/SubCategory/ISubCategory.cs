using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.Category;
using ENT.Model.Common;
using ENT.Model.SubCategory;

namespace ENT.BL.SubCategory
{
    public interface ISubCategory
    {
        Task<APIResponseModel> Add(SubCategoryModel objSubCategory);
        Task<APIResponseModel> GetAll();
        Task<APIResponseModel> GetById(int SubCategoryId);
        Task<APIResponseModel> Update(SubCategoryModel objSubCategory);
        Task<APIResponseModel> Delete(int SubCategoryId);
    }
}
