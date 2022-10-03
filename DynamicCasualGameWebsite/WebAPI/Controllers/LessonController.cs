using BusinessTier.Services;
using BusinessTier.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //[Route("api/Lesson")]
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonservice _service;
        public LessonController(ILessonservice service)
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
        public ActionResult<BaseResponsePagingViewModel<LessonResponseModel>> GetLesson([FromQuery] LessonResponseModel filter,
            [FromQuery] PagingModel paging)
        {
            return Ok(_service.GetAllLesson(filter, paging));
        }
    }
}
