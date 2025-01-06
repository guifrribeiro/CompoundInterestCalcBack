using CompoundInterestCalcBack.Models;
using CompoundInterestCalcBack.Services;
using Microsoft.AspNetCore.Mvc;

namespace CompoundInterestCalcBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICompoundInterestService interestService;

        public CalculatorController(ICompoundInterestService interestService)
        {
            this.interestService = interestService;
        }

        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] CalculationRequest request)
        {
            if (request == null || request.InterestRate <= 0 || request.Principal <= 0 || request.Periods <= 0)
            {
                return BadRequest("Invalid input data.");
            }

            var result = interestService.Calculate(request.Principal, request.InterestRate, request.Periods, request.Contribution);

            return Ok(new { TotalAmount = result });
        }        
    }
}