using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.Application;
using ProEventos.Domain;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEventoService eventoService;

        public EventoController(IEventoService eventoService) // recebe o contexto de BD por injecao de dependencia
        {
            this.eventoService = eventoService;
        }

           	

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var eventos = await eventoService.GetAllEventosAsync(true);
                if (eventos == null)
                {
                    return NotFound("nada encontrado");
                }

                return Ok(eventos);
            }
            catch (System.Exception e)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro: {e.Message}");
            }
        }

        // [HttpGet("(id)")]
        // public IEnumerable<Evento> Get(int id)
        // {
        //     // return context.Eventos.Where(evento => evento.Id == id);
        // }

    }
}
