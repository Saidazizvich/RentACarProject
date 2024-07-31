using Applicaion.Features.Brands.Commands.Create;
using Applicaion.Features.Brands.Commands.Delete;
using Applicaion.Features.Brands.Commands.Update;
using Applicaion.Features.Brands.Quries.GetById;
using Applicaion.Features.Brands.Quries.GetList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : BaseController
    {
        [HttpPost]

        public async Task<IActionResult> Add([FromBody] CreatedBrandCommand createdBrandCommand) // istek request
        {
            CreatedBrandResponse  brandResponse = await Mediator.Send(createdBrandCommand);
     
            return Ok(brandResponse); // 200 success

        }


        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListBrandQuery getListBrandQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListBrandListItemDto> response = await Mediator.Send(getListBrandQuery);
            return Ok(response);    
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetListById([FromRoute] Guid id)
        {
            GetListBrandQuery getListBrandQuery = { Id = id };

            GetByIdListResponse getById = await Mediator.Send(getListBrandQuery);

            return Ok(getById);
        }

        [HttpPut]
        public async Task<IActionResult> GetById([FromBody] UpdateBrandCommand updateBrandCommand) // istek request
        {
            UpdateBrandResponse brandResponse = await Mediator.Send(updateBrandCommand);

            return Ok(brandResponse); // 200 success

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id) // istek request
        {
                DeleteBrandResponse   brandResponse = await Mediator.Send(new DeleteBrandResponse { Id = id});

            return Ok(brandResponse); // 200 success

        }

    }
}
