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

    }
}
