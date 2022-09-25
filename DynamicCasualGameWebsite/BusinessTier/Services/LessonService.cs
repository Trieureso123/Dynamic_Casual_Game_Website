using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessTier.Commons;
using BusinessTier.ViewModels;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier.Services
{
    public interface ILessonservice
    {
        BaseResponsePagingViewModel<LessonResponseModel> GetAllLesson(LessonResponseModel filter, PagingModel paging);
    }

    public class LessonService : ILessonservice
    {
        private readonly ILessonRepositories _lessonRepo;
        private readonly IMapper _mapper;

        public LessonService(ILessonRepositories lessonRepo, IMapper mapper)
        {
            _lessonRepo = lessonRepo;
            _mapper = mapper;
        }

        public BaseResponsePagingViewModel<LessonResponseModel> GetAllLesson(LessonResponseModel filter, PagingModel paging)
        {
            var lesson = _lessonRepo.Get();
            if (lesson != null)
            {
                var result = lesson.OrderBy(x => x.IdLesson)
                    .ProjectTo<LessonResponseModel>(_mapper.ConfigurationProvider)
                    .DynamicFilter<LessonResponseModel>(filter)
                    .PagingQueryable(1, 1, CommonConstants.LimitPaging, CommonConstants.DefaultPaging);

                return new BaseResponsePagingViewModel<LessonResponseModel>()
                {
                    Metadata = new PagingMetadata()
                    {
                        Page = paging.Page,
                        Size = paging.Size,
                        Total = result.Item1
                    },
                    Data = result.Item2.ToList()
                };
            }
            return null;
        }
    }
}
