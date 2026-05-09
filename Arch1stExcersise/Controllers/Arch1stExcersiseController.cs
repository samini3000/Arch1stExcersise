using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Arch1stExcersise.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Arch1stExcersiseController : ControllerBase
    {

        private readonly ILogger _logger;
        private readonly IPerfomanceTestingService _perfomanceTestingService;
        public Arch1stExcersiseController(ILogger<Arch1stExcersiseController> logger, IPerfomanceTestingService perfomanceTestingService)
        {

            this._logger = logger;
            _perfomanceTestingService = perfomanceTestingService;
        }

        [HttpGet]
        public async Task<IActionResult> AsyncGetReport()
        {
            await _perfomanceTestingService.AsyncTask();
            return Ok();
        }

        [HttpGet]
        public  IActionResult BadAsyncGetReport()
        {
            _perfomanceTestingService.BadAsynctask();
            return Ok();
        }


        [HttpGet]
        public IActionResult SyncGetReport()
        {
            _perfomanceTestingService.SyncThread();
            return Ok();
        }
    }
}
