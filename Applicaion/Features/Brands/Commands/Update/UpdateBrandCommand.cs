using Applicaion.Service.Repositories;
using AutoMapper;
using Domain.Entitties;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaion.Features.Brands.Commands.Update
{
    public class UpdateBrandCommand : IRequest<UpdateBrandResponse>
    {
        public string Name { get; set; }
        

    }

    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, UpdateBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public UpdateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<UpdateBrandResponse> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
              Brand? brand = await _brandRepository.GetAsync(perdicate: b=>b.Id ==  request.Id, cancellationToken: cancellationToken);
            
             brand = _mapper.Map<Brand>(request ,brand);
            await _brandRepository.UpdateAsync(brand);


           UpdateBrandResponse response =  _mapper.Map<UpdateBrandResponse>(brand);

             return response;   
        }
    }
}
