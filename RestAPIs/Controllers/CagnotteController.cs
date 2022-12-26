using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CagnotteController : Controller
    {

        private readonly IServiceCagnotte cagnotteService;
        private readonly IServiceEntreprise entrepriseService;
        public CagnotteController(IServiceCagnotte sc, IServiceEntreprise se)
        {
            cagnotteService = sc;
            entrepriseService = se;
        }

        // GET: CagnotteController
        [HttpGet] 
        public IActionResult GetAllCagnotte()
        {
            
            return Ok(cagnotteService.GetMany());

        }

        [HttpPost]
        [Route("create")]
        public IActionResult AddCagnotte([FromBody] Cagnotte cagnotte )
        {
            try
            {
                Console.WriteLine(cagnotte);
                cagnotteService.Add(cagnotte);
                cagnotteService.Commit();
                return Ok(cagnotte);
            }
            catch (Exception ex)
            {
                return Ok(ex);
                Console.WriteLine(ex);
            }
        }

    }
}
