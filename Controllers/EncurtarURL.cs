using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_EncurtadorURL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncurtarURL : ControllerBase
    {
        
        public ActionResult Encurtar(string strURL)
        {
            
            if (strURL != null)
                return new ObjectResult(Encurtador.Encurtador_URL(strURL));
            else
                return StatusCode(408);
            
        }


        [HttpPost]
        public ActionResult Post([FromBody] string URL, string Key)
        {

            return BadRequest();
            
        }

    }
}
