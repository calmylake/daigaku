using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PGTData.Models;

namespace PGTData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        string[] stringinha = {"primeiro valor", "segundo valor", "", "", "", "", "", ""};

        // GET api/review
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return stringinha;
        }

        // GET api/review/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if(id<1||id>stringinha.Length) return "deu ruim";
            id = id-1;
            return stringinha[id];
        }

        // POST api/review
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Console.WriteLine("jhsfajkhfsajhlkfsjfshfhjkfsahjksfjhafjhskjhkfaskjh"+value);
            if(value!=""){
                int i = 0;
                while(i<stringinha.Length){
                    if(stringinha[i]==""){
                        stringinha[i] = value;
                    }
                    i++;
                }
            }
        }

        // PUT api/review/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/review/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if(id<1||id>stringinha.Length) return;
            id = id-1;
            stringinha[id] = "";
        }
    }
}
