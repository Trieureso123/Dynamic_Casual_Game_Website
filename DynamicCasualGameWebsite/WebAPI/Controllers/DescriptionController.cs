using BusinessTier.Services;
using BusinessTier.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //[Route("api/Description")]
    [Route("api/[controller]")]
    [ApiController]
    public class DescriptionController : ControllerBase
    {
        private readonly IDescriptionService _service;
        public DescriptionController(IDescriptionService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get all courses
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="paging"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<BaseResponsePagingViewModel<DescriptionResponseModel>> GetDescription([FromQuery] DescriptionResponseModel filter,
            [FromQuery] PagingModel paging)
        {
            return Ok(_service.GetAllDescription(filter, paging));
        }
    }
}
