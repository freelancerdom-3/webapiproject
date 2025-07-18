using ENT.BL.SubCategory;
using ENT.Model.Common;
using ENT.Model.SubCategory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.SubCategory
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategory _subCategory;
        public SubCategoryController(ISubCategory SubCategory)
        {
            _subCategory = SubCategory;
        }
        [HttpPost]
        public async Task<APIResponseModel> Add(SubCategoryModel objSubCategoryModel)
        {
            return await _subCategory.Add(objSubCategoryModel);
        }
        [HttpPut]
        public async Task<APIResponseModel> Update(SubCategoryModel objSubCategoryModel)
        {
            return await _subCategory.Update(objSubCategoryModel);
        }
        [HttpDelete]
        public async Task<APIResponseModel> Delete(int SubCategoryId)
        {
            return await _subCategory.Delete(SubCategoryId);
        }
        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int SubCategoryId)
        {
            return await _subCategory.GetById(SubCategoryId);
        }
        [HttpGet]
        public async Task<APIResponseModel> GetAll()
        {
            return await _subCategory.GetAll();
        }
        
        [HttpGet("GetByCategoryId")]
        public async Task<APIResponseModel> GetByCategoryId(int CategoryId )
        {
            return await _subCategory.GetBycategoryId(CategoryId);
        }

        [HttpGet("GetTopTrending")]
        public async Task<APIResponseModel> getTrendingSubCategories(int maxTrendingRecords)
        {
            return await _subCategory.GetTopTrending(maxTrendingRecords);
        }

        [HttpGet("GetAllSkill")]
        [AllowAnonymous]
        public async Task<APIResponseModel> GetAllSkillType( )
        {
            return await _subCategory.GetAllSkillType();
        }

    }
}
