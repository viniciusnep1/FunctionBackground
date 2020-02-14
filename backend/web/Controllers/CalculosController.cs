using core.seedwork;
using Microsoft.AspNetCore.Mvc;
using services.services.calc;
using System.Threading.Tasks;

namespace web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CalculosController : BaseController
    {
        private readonly QueryVolumes query;
        public CalculosController(QueryVolumes query)
        {
            this.query = query;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await query.InserValues();
            return Ok(new Response(result));
        }

    }
}
