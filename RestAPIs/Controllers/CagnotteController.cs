using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Threading.Tasks;
using Data;
using Microsoft.EntityFrameworkCore;


namespace RestAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CagnotteController : Controller
    {

        private readonly IServiceCagnotte cagnotteService;
        private readonly IServiceEntreprise entrepriseService;
        private readonly Context _context;
        public CagnotteController(IServiceCagnotte sc, IServiceEntreprise se,Context ctx)
        {
            _context = ctx;
            cagnotteService = sc;
            entrepriseService = se;
        }

        // GET: CagnotteController
        [HttpGet] 
        public async Task<IActionResult> GetAllCagnotte()
        {
            
            return Ok(await _context.Entreprise.ToArrayAsync());

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
                return BadRequest(ex);
                
            }
        }

    }
}
