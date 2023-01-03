using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace RestAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrepriseController : Controller
    {
        private readonly IServiceEntreprise entrepriseService;
        public EntrepriseController(IServiceEntreprise se)
        {

            entrepriseService = se;
        }

        // GET: EntrepriseController
        [HttpGet]
        public IActionResult GetAllEntreprises()
        {

            return Ok(entrepriseService.GetMany());

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Entreprise entreprise = entrepriseService.GetById(id);
            if (entreprise != null)
            {
                return Ok(entreprise);
            }
            return NotFound();
        }


        [HttpPost]
        [Route("create")]
        public IActionResult AddEntreprise([FromBody] Entreprise  entreprise )
        {
            try
            {
               
                entrepriseService.Add(entreprise);
                entrepriseService.Commit();
                return Ok(entreprise);
            }
            catch (Exception ex)
            {
             
                return BadRequest(ex);
            }
        }
        // PUT: ProductController/Edit/5
        [HttpPut]
        [Route("update")]
        public IActionResult EditEntreprise([FromBody] Entreprise entreprise)
        {
            
                try
                {

                 entrepriseService.Update(entreprise);
                entrepriseService.Commit();

                  return  Ok(entreprise);
                }
                catch(DbUpdateConcurrencyException)
                {
                    if (!EntrepriseExists(entreprise.EntrepriseId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }

                }

                
            
        }
        
        private bool EntrepriseExists(int id)
        {
            return entrepriseService.GetMany().Any(e => e.EntrepriseId == id);
        }
 
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult deleteEntreprise( int  id )
        {
         

            var entreprise = entrepriseService.GetById(id);

            if(entreprise == null)
            {
                return NotFound();
            }
            try
            {
                
                
                entrepriseService.Delete(entreprise);
                entrepriseService.Commit();
                return Ok(entreprise);
            }
            catch (Exception ex)
            {
               
                return BadRequest(ex);
            }
        }

    }
}
