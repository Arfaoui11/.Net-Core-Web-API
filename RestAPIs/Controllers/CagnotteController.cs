using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Linq;
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
       
        public CagnotteController(IServiceCagnotte sc, IServiceEntreprise se)
        {
           
            cagnotteService = sc;
            entrepriseService = se;
        }

        // GET: CagnotteController
        [HttpGet] 
        public  IActionResult GetAllCagnotte()
        {
            
            return Ok(cagnotteService.GetMany());

        }
        
        // GET: CagnotteController
        [HttpGet]
        [Route("enCours")]
        public  IActionResult GetCagnotteEnCours()
        {
            
            return Ok( cagnotteService.EnCours());

        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Cagnotte cagnotte  = cagnotteService.GetById(id);
            if (cagnotte != null)
            {
                return Ok(cagnotte);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult AddCagnotte([FromBody] Cagnotte cagnotte )
        {
            try
            {
                
                cagnotteService.Add(cagnotte);
                cagnotteService.Commit();
                return Ok(cagnotte);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                
            }
        }
        
        // PUT: ProductController/Edit/5
        [HttpPut]
        [Route("update")]
        public IActionResult EditCagnotte([FromBody] Cagnotte cagnotte)
        {
            
            try
            {

                cagnotteService.Update(cagnotte);
                entrepriseService.Commit();

                return  Ok(cagnotte);
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!CagnotteExists(cagnotte.CagnotteId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }

            }

                
            
        }
        private bool CagnotteExists(int id)
        {
            return cagnotteService.GetMany().Any(c => c.CagnotteId == id);
        }

    }
}
