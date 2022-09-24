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
    public interface IQuestionService
    {
        BaseResponsePagingViewModel<QuestionResponeModel> GetAllQuestion(QuestionResponeModel filter, PagingModel paging);
        QuestionResponeModel CreateQuestion(QuestionRequestModel request);
    }

    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public QuestionResponeModel CreateQuestion(QuestionRequestModel request)
        {
            if (request == null)
            {
                return null;
            }
            else
            {
                var question = _mapper.Map<Question>(request); // đưa data mới vừa add vào model bằng Mapps
                return _mapper.Map<QuestionResponeModel>(_questionRepository.Create(question));
            }
        }

        public BaseResponsePagingViewModel<QuestionResponeModel> GetAllQuestion(QuestionResponeModel filter, PagingModel paging)
        {
            var question = _questionRepository.Get();
            if (question != null)
            {
                var result = question.OrderBy(x => x.IdQuestion)
                    .ProjectTo<QuestionResponeModel>(_mapper.ConfigurationProvider)
                    .DynamicFilter<QuestionResponeModel>(filter)
                    .PagingQueryable(paging.Page, paging.Size, CommonConstants.LimitPaging, CommonConstants.DefaultPaging);
                return new BaseResponsePagingViewModel<QuestionResponeModel>()
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
