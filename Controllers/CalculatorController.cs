using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Calculate")]
        public IActionResult Calculate(decimal FirstNumber, decimal SecondNumber,string ActionType)
        {
            decimal result;
            //--------------------------------
            switch (ActionType)
            {
                case "+":
                    result = FirstNumber + SecondNumber;
                    break;

                case "-":
                    result = FirstNumber - SecondNumber;
                    break;

                case "*":
                    result = FirstNumber * SecondNumber;
                    break;

                case "/":
                    result = FirstNumber / SecondNumber;
                    break;

                default:
                    result = 0;
                    return NotFound(result);
                     
            }
            //--------------------------------
            return Ok(result);
        }
    }
}
