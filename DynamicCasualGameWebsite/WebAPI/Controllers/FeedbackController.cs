using BusinessTier.Services;
using BusinessTier.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _service;
        public FeedbackController(IFeedbackService service)
        {
            _service = service;
        }


        /// <summary>
        /// Get all courses
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="filterModel"></param>
        /// <param name="paging"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<BaseResponsePagingViewModel<FeedbackResponeModel>> GetCourses([FromQuery] FeedbackResponeModel filter,
            [FromQuery] PagingModel paging)
        {
            return Ok(_service.GetAllFeedback(filter, paging));
        }
    }
}
