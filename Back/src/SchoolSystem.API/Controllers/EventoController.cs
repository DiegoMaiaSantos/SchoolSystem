using Microsoft.AspNetCore.Mvc;

namespace SchoolSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "Exemplo do Get";
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo do Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo do Put: {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo do Delete: {id}";
        }
    }
}