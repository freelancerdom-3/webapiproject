using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        // sub category name should be unique in add and update,  alpesh will take care
       
        Task<APIResponseModel> Add(SubCategoryModel objSubCategory);
        Task<APIResponseModel> GetAll(); // inner join
        Task<APIResponseModel> GetById(int SubCategoryId);// add same for categoryId and result should ne in list
        Task<APIResponseModel> GetBycategoryId(int categoryId);
        Task<APIResponseModel> Update(SubCategoryModel objSubCategory);
        Task<APIResponseModel> Delete(int SubCategoryId);
        Task<APIResponseModel> GetTopTrending(int maxTrendingRecords);
        Task<APIResponseModel> GetAllSkillType();
    }
}
