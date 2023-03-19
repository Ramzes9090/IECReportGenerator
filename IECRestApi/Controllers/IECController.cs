using IECReportGenreator;
using IECReportGenreator.Infrastructure;
using IECReportGenreator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IECRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IECController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<IECModel> Get()
        {
            var generator = new IECReportGenerator(new WindReader(),
                                       new IECWriter());

            return generator.GenerateReport("data.json");
            
        }

    }
}
