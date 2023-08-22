using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Dev_front.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwaggerController : ControllerBase
    {
        List<Swagger> swaggers = new List<Swagger>()
        {
            new Swagger() { Id=1, Name = "Oscar"},
            new Swagger() { Id=2, Name = "Martinez"},
            new Swagger() { Id=3, Name = "Mojica"},    
        };
        [HttpGet]
        public ActionResult<Swagger> Get(int Id) 
        {
             var swagger = swaggers.Where(d=>d.Id == Id).FirstOrDefault();
            if(swagger == null) return NotFound();
            return swagger;
        }
    }

    public class Swagger
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
