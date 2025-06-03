using ENT.BL.SubCategory;
using ENT.Model.Common;
using ENT.Model.SubCategory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.SubCategory
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategory _SubCategory;
        public SubCategoryController(ISubCategory SubCategory)
        {
            _SubCategory = SubCategory;
        }
        [HttpPost]
        public async Task<APIResponseModel> Add(SubCategoryModel objSubCategoryModel)
        {
            return await _SubCategory.Add(objSubCategoryModel);
        }
        [HttpPut]
        public async Task<APIResponseModel> Update(SubCategoryModel objSubCategoryModel)
        {
            return await _SubCategory.Update(objSubCategoryModel);
        }
        [HttpDelete]
        public async Task<APIResponseModel> Delete(int SubCategoryId)
        {
            return await _SubCategory.Delete(SubCategoryId);
        }
        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int SubCategoryId)
        {
            return await _SubCategory.GetById(SubCategoryId);
        }
        [HttpGet]
        public async Task<APIResponseModel> GetAll()
        {
            return await _SubCategory.GetAll();
        }
        [HttpGet("GetByName")]
        public async Task<APIResponseModel> GetByName(string subCategoryName)
        {
            return await _SubCategory.GetByName(subCategoryName);
        }

    }
}
