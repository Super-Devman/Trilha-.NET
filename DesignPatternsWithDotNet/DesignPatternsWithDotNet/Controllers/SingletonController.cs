using Microsoft.AspNetCore.Mvc;
using DesignPatternsWithDotNet.Infra.Singleton;


namespace DesignPatternsWithDotNet.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        public SingletonController(SingletonContainer singletonContainer)
        {
            singletonContainer = singletonContainer;
        }


        public SingletonContainer SingletonContainer { get; }

        // GET api/v1/<VeiculosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return id switch
            {
                1 => Ok(SingletonContainer),
                _ => Ok(Singleton.Instace)
            };
        }
    }
}

