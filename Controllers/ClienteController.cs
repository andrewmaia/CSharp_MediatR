using CSharp_MediatR.MediatR.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CSharp_MediatR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController :  ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IMediator _mediator;        

        public ClienteController(ILogger<ClienteController> logger,IMediator mediator)
        {
            _logger = logger;
            _mediator =mediator;
        }


        [HttpPost]
        public async Task<IActionResult> Post(ClienteInsertRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
            
        }


    }
}