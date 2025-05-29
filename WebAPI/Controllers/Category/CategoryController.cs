using ENT.BL.Category;
using ENT.Model.Common;
using ENT.Model.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Category
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategory _Category;
        public CategoryController(ICategory Category)
        {
            _Category = Category;
        }
        [HttpPost]
        public async Task<APIResponseModel> Add(CategoryModel objCategoryModel)
        {
            return await _Category.Add(objCategoryModel);
        }
        [HttpPut]
        public async Task<APIResponseModel> Update(CategoryModel objCategoryModel)
        {
            return await _Category.Update(objCategoryModel);
        }
        [HttpDelete]
        public async Task<APIResponseModel> Delete(int CategoryId)
        {
            return await _Category.Delete(CategoryId);
        }
        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int CategoryId)
        {
            return await _Category.GetById(CategoryId);
        }
        [HttpGet]
        public async Task<APIResponseModel> GetAll()
        {
            return await _Category.GetAll();
        }
    }
}
