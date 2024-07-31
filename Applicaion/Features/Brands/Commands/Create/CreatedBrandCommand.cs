using Applicaion.Service.Repositories;
using AutoMapper;
using Domain.Entitties;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaion.Features.Brands.Commands.Create;

               // istek                         // sonuc
public class CreatedBrandCommand: IRequest<CreatedBrandResponse>  // Mediator
{
   
    public string Name { get; set; } // bu esa istek yani request
                                     // bu islem neden lazim biza yani biza crud islem yapmak icin lazim dikkat !!!!

    // CQRS islemi yani Command Query Responsiblity Segretation
    public class CreatedBrandCommandHandler : IRequestHandler<CreatedBrandCommand, CreatedBrandResponse> // toplam isi yapacak
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;


        public CreatedBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        // istek                // sonuc
        public async Task<CreatedBrandResponse>? Handle(CreatedBrandCommand request, CancellationToken cancellationToken) // ? == nul
        {
            var result =  _mapper.Map<Brand>(request);
            
            var response = await _brandRepository.AddAsync(result);   
             
              

            CreatedBrandResponse createdBrandResponse = _mapper.Map<CreatedBrandResponse>(response);
            createdBrandResponse.Name = request.Name; // istek
            createdBrandResponse.Id = new Guid(); // istek
            return null;  
        }
    }
}
