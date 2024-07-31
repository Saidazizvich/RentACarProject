using Applicaion.Features.Brands.Commands.Create;
using Applicaion.Features.Brands.Commands.Delete;
using Applicaion.Features.Brands.Commands.Update;
using Applicaion.Features.Brands.Quries.GetById;
using Applicaion.Features.Brands.Quries.GetList;
using AutoMapper;
using Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaion.Features.Brands.Profiles
{
    public class BrandProfile : Profile // Dto  Data Object Transaction dikkat onemli
    {
        public BrandProfile()
        {
            CreateMap<Brand, CreatedBrandCommand>().ReverseMap(); // request
            CreateMap<Brand, CreatedBrandResponse>().ReverseMap(); // respone
            CreateMap<Brand, GetListBrandListItemDto>().ReverseMap(); // respone
            CreateMap<Brand, GetByIdListResponse>().ReverseMap();// response 
            CreateMap<Brand,UpdateBrandResponse>().ReverseMap();    // response
            CreateMap<Brand,DeleteBrandResponse>().ReverseMap();    // response

            CreateMap<Paginate<Brand>, GetListResponse<GetListBrandListItemDto>>().ReverseMap();    
        }
    }
}
