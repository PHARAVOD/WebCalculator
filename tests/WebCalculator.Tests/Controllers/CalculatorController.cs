using Microsoft.AspNetCore.Mvc;
using WebCalculator.Models;

namespace WebCalculator.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly CalculatorService _calculatorService = new();

    [HttpPost("calculate")]
    public ActionResult<CalculatorResponse> Calculate([FromBody] CalculatorRequest request)
    {
        try
        {
            var result = _calculatorService.Calculate(
                request.Number1,
                request.Number2,
                request.Operation
            );
            return Ok(new CalculatorResponse { Success = true, Result = result });
        }
        catch (Exception ex)
        {
            return BadRequest(new CalculatorResponse
            {
                Success = false,
                Error = ex.Message
            });
        }
    }

    [HttpGet("operations")]
    public ActionResult<List<string>> GetAvailableOperations()
    {
        return Ok(new List<string> { "add", "subtract", "multiply", "divide", "power" });
    }
}