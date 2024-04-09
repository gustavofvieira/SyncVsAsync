using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Domain.Data;
using System.IO;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BenchMarkController : ControllerBase
    {
        private readonly ILogger<BenchMarkController> _logger;

        public BenchMarkController(ILogger<BenchMarkController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            
            return "https://localhost:44375/benchmark/consume-sync  https://localhost:44375/benchmark/consume-async";
        }

        [HttpGet("consume-sync")]
        public ActionResult<Database> ConsumeSync()
        {
            var consume = new ConsumeDataSync();
            var file2 = "C://Users//gusta//OneDrive//Documentos//Github//sync-async//Domain//Data//thousand.json";
            return consume.Execute(file2);
        }

        [HttpGet("produce-sync")]
        public ActionResult<string> ProduceSync()
        {
            var produce = new ProduceDataSync();
            return produce.Execute();
        }

        [HttpGet("consume-async")]
        public async Task<Database> ConsumeAsync()
        {
            var consume = new ConsumeData();
            //var file = Directory.GetCurrentDirectory();
            var file2 = "C://Users//gusta//OneDrive//Documentos//Github//sync-async//Domain//Data//thousand.json";
            return await consume.Execute(file2);
        }

        [HttpGet("produce-async")]
        public async Task<string> ProduceAsync()
        {
            var produce = new ProduceData();

            return await produce.Execute();
        }
    }
}
