using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessTier.Commons;
using BusinessTier.RequestModels;
using BusinessTier.ViewModels;
using DataAccess.Models;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier.Services
{
    public interface IFeedbackService
    {
        BaseResponsePagingViewModel<FeedbackResponeModel> GetAllFeedback(FeedbackResponeModel filter, PagingModel paging);
        FeedbackResponeModel CreatFeedback (FeedbackRequestModel request);
    }

    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepositories _feedbackRepo;
        private readonly IMapper _mapper;

        public FeedbackService(IFeedbackRepositories feedbackRepo, IMapper mapper)
        {
            _feedbackRepo = feedbackRepo;
            _mapper = mapper;
        }

        public FeedbackResponeModel CreatFeedback(FeedbackRequestModel request)
        {
            if (request == null)
            {
                return null;
            }
            else
            {
                var feedback = _mapper.Map<Feedback>(request);
                return _mapper.Map<FeedbackResponeModel>(_feedbackRepo.Create(feedback));
            }
        }

        public BaseResponsePagingViewModel<FeedbackResponeModel> GetAllFeedback(FeedbackResponeModel filter, PagingModel paging)
        {
            var feedback = _feedbackRepo.Get();
            if (feedback != null)
            {
                var result = feedback.OrderBy(x => x.IdFeedback)
                     .ProjectTo<FeedbackResponeModel>(_mapper.ConfigurationProvider)
                     .DynamicFilter<FeedbackResponeModel>(filter)
                     .PagingQueryable(paging.Page, paging.Size, CommonConstants.LimitPaging, CommonConstants.DefaultPaging);
                return new BaseResponsePagingViewModel<FeedbackResponeModel>()
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
