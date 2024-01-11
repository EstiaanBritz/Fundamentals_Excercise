using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.Interfaces;


namespace Fundamentals_Excercise.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FactorialGenerateController : ControllerBase
    {
        private readonly IFactorialService _factorialService;
        public FactorialGenerateController(IFactorialService factorialService)
        {
            this._factorialService = factorialService;
        }
        [HttpGet]

        public int GenerateFactorialNumber(int input)
        {
            return _factorialService.Generatefactorial(input);
        }
    }
}
