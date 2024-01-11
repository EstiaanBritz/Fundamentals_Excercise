using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.Interfaces;

namespace Fundamentals_Excercise.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SentenceReverseController : ControllerBase
    {
        private readonly ISentenceReverseService _sentenceReverseService;

        public SentenceReverseController(ISentenceReverseService sentenceReverseService)
        {
            _sentenceReverseService = sentenceReverseService;
        }

        [HttpGet]
        public string GenerateReverseSentence(string input)
        {
            return _sentenceReverseService.SentenceReverser(input);
        }
    }
}
