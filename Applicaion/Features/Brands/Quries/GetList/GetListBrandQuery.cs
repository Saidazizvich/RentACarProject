using Applicaion.Service.Repositories;
using AutoMapper;
using Domain.Entitties;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaion.Features.Brands.Quries.GetList
{
    public class GetListBrandQuery : IRequest<GetListResponse<GetListBrandListItemDto>>
    {
        public PageRequest PageRequest { get; set; }

        // simdi 
        public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery, GetListResponse<GetListBrandListItemDto>>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }
        }

        public async Task<GetListBrandListItemDto> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
        {
            Paginate<Brand> paginate = await _brandRepository.GetLisAsync(
                 index: request.PageRequest.PageIndex,
                 size: request.PageRequest.PageSize,
                 cancellationToken: cancellationToken
                 );

        }  
               
            GetListResponse<GetListBrandListItemDto> getListResponse = _mapper.CreateMap<GetListResponse<GetListBrandListItemDto>>(paginate)
               
            return paginate;
        
    }
}
