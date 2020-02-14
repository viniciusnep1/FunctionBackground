using core.seedwork;
using Microsoft.AspNetCore.Mvc;
using services.services.calc;
using System.Threading.Tasks;

namespace web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class XptoController : BaseController
    {
        private readonly QueryVolumes query;
        public XptoController(QueryVolumes query)
        {
            this.query = query;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduzidosAsync()
        {
            var result = await query.FillCharts();
            return Ok(new Response(result));
        }

    }
}
