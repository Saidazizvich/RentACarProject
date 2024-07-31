using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApiUI.Controllers
{
    public class BaseController : ControllerBase // inheritance
    {
        private IMediator? _mediator; // depency injection  

        // sadece burda miras alan icin calisiyor 
        protected IMediator? Mediator =>  _mediator??=HttpContext.RequestServices.GetService<IMediator>();    
    }
}
