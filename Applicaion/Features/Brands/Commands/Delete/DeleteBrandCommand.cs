using Applicaion.Features.Brands.Commands.Update;
using Applicaion.Service.Repositories;
using AutoMapper;
using Domain.Entitties;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaion.Features.Brands.Commands.Delete
{
    public class DeleteBrandCommand : IRequest<DeleteBrandResponse>
    {
        public Guid  Id { get; set; }

       
    }

    public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommand, DeleteBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper mapper;

        public DeleteBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            this.mapper = mapper;
        }

        public Task<DeleteBrandResponse> Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(perdicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            brand = _mapper.Map<Brand>(request, brand);
            await _brandRepository.DeleteAsync(brand);


            UpdateBrandResponse response = _mapper.Map<UpdateBrandResponse>(brand);

            return response;
        }
    }
}
