using BusinessTier.RequestModels;
using BusinessTier.Services;
using BusinessTier.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _service;
        public QuestionController(IQuestionService service)
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
        public ActionResult<BaseResponsePagingViewModel<QuestionResponeModel>> GetCourses([FromQuery] QuestionResponeModel filter,
            [FromQuery] PagingModel paging)
        {
            return Ok(_service.GetAllQuestion(filter, paging));
        }


        /// <summary>
        /// Create a new course
        /// </summary>
        /// <param name="QuestionRequestModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<QuestionResponeModel> CreateCourse(QuestionRequestModel request)
        {
            if (request.Question1 == "" || request.Email == "" || request.PhoneNumber == "")
            {
                return BadRequest();
            }
            else
            {
                return _service.CreateQuestion(request);
            }
        }

    }
}
