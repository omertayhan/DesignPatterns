using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatrWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CalculatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("Multiply")]
        public async Task<int> Multiply(int val1, int val2)
        {
            MultiplyRequest request = new MultiplyRequest() { Val1 = val1, Val2 = val2 };
            return await _mediator.Send(request);
        }
    }
}