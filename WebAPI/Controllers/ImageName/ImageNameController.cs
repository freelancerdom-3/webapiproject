using ENT.BL.ImageName;
using ENT.Model.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.ImageName
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageNameController : ControllerBase
    {
        private readonly IImageName _imageNameService;

        public ImageNameController(IImageName imageNameService)
        {
            _imageNameService = imageNameService;
        }

        [HttpGet]
        public async Task<APIResponseModel> GetAll()
        {
            return await _imageNameService.GetAll();
        }

        [HttpGet("GetByIdAndType")]
        public async Task<APIResponseModel> GetByIdAndType(int categorizedTypeId, string categorizedTypeName)
        {
            return await _imageNameService.GetByIdAndType(categorizedTypeId, categorizedTypeName);
        }
    }
}
