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
    public interface IDescriptionService
    {
        BaseResponsePagingViewModel<DescriptionResponseModel> GetAllDescription(DescriptionResponseModel filter, PagingModel paging);
    }

    public class DescriptionService : IDescriptionService
    {
        private readonly IDescriptionRepositories _descriptionRepo;
        private readonly IMapper _mapper;

        public DescriptionService(IDescriptionRepositories descriptionRepo, IMapper mapper)
        {
            _descriptionRepo = descriptionRepo;
            _mapper = mapper;
        }

        public BaseResponsePagingViewModel<DescriptionResponseModel> GetAllDescription(DescriptionResponseModel filter, PagingModel paging)
        {
            var description = _descriptionRepo.Get();
            if (description != null)
            {
                var result = description.OrderBy(x => x.IdDescription)
                   .ProjectTo<DescriptionResponseModel>(_mapper.ConfigurationProvider)
                   .DynamicFilter<DescriptionResponseModel>(filter)
                   .PagingQueryable(paging.Page, paging.Size, CommonConstants.LimitPaging, CommonConstants.DefaultPaging);

                return new BaseResponsePagingViewModel<DescriptionResponseModel>()
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
