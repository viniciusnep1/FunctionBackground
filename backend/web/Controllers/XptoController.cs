using core.seedwork;
using Microsoft.AspNetCore.Mvc;
using services.services.calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class XptoController : BaseController
    {
        private readonly queryVolumesPlanejadosProduzidos query;
        public XptoController(queryVolumesPlanejadosProduzidos query)
        {
            this.query = query;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduzidosAsync()
        {
            var result = await query.PopularGrafico();
            return Ok(new Response(result));
        }

    }
}
