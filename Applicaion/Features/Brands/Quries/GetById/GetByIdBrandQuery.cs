using Applicaion.Service.Repositories;
using AutoMapper;
using Domain.Entitties;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaion.Features.Brands.Quries.GetById
{
    public class GetByIdBrandQuery : IRequest<GetByIdListResponse>
    {
        public Guid Id { get; set; }



    }

        
    public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery,GetByIdListResponse>
    {
            private readonly IMapper _mapper;
            private readonly IBrandRepository _brandRepository;

        public GetByIdBrandQueryHandler(IMapper mapper, IBrandRepository brandRepository)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
        }

        public async Task<GetByIdListResponse> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
        {
          Brand? brand = await _brandRepository.GetAsync(perdicate: b => b.Id, request.Id, cancellationToken: cancellationToken);

              
             GetByIdListResponse response =  _mapper.Map<GetByIdListResponse>(brand);


            return response;    
        }
    }
}
