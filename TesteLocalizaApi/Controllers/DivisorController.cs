using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteLocalizaApi.Model;
using TesteLocalizaApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteLocalizaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisorController : ControllerBase
    {
   
     
        [HttpGet("{number}/{prime}")]
        public ActionResult<IList<int>> Get(int number, bool prime)
        {
            DivisorServices _divisorService = new DivisorServices();
            Divisor divisor = new Divisor
            {
                Number = number,
                Prime = prime
            };

            var result = _divisorService.CalculateDivisor(divisor);

            if (result.OK)
            {
                return Ok(result.Divisors);
            }
            else
            {
                return BadRequest(result.Erro);
            }

        }


    }
}
