using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet("SayHello")]
        public string HelloWorld()
        {
            string fm;
            fm = "Hi this my first restful api";
            //--------------------------------
            return fm;
        }

        //--------------

        [HttpGet("SayHelloAction")]
        public IActionResult SayHelloAction()
        {
            string fm;
            fm = "Hi this my first restful api";
            //--------------------------------
            return Ok(fm);
        }


        //====================================
        [HttpGet("SayHelloFirstName")]
        public IActionResult SayHelloFirstName(string FirstName)
        {
            string fm;
            fm = "Hi! "+ FirstName + " this is my first Param api";
            //--------------------------------
            return Ok(fm);
        }
        //------------
        [HttpGet("SayHelloFullName")]
        public IActionResult SayHelloFullName(string FirstName,string LastName)
        {
            string fm;
            fm = "Hi! " + FirstName +" "+ LastName+ " this is my first Param api";
            //--------------------------------
            return Ok(fm);
        }
    }
}
