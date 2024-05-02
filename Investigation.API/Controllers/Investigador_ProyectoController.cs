using Investigation.API.Data;
using Investigation.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Controllers
{
    [ApiController]
    [Route("/api/Investigador_Proyecto")]
    public class Investigador_ProyectoController : ControllerBase
    {
        private readonly DataContext _context;

        public Investigador_ProyectoController(DataContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult> GetInvestigador_Proyecto()
        {
            var Investigador_Proyectos = await _context.Investigador_Proyectos
                .Include(ar => ar.Investigadoress)
                .Include(ar => ar.ProyectoInvestigaciones)
                .ToListAsync();
            return Ok(Investigador_Proyectos);
        }

        // POST
        [HttpPost]
        public async Task<ActionResult> Post(int Id_Investigador, int Id_Proyecto)
        {
            var Investigador = await _context.Investigadores.FindAsync(Id_Investigador);
            var Proyecto = await _context.ProyectoInvestigaciones.FindAsync(Id_Proyecto);

            if (Investigador == null)
            {
                return NotFound("Investigador no encontrado");
            }
            if (Proyecto == null)
            {
                return NotFound("Proyecto no encontrado");
            }

            var IdInvestigatorProyect = new Investigador_Proyecto
            {
                Investigadoress = Investigador,
                ProyectoInvestigaciones = Proyecto

            };

            _context.Investigador_Proyectos.Add(IdInvestigatorProyect);
            await _context.SaveChangesAsync();

            return Ok(IdInvestigatorProyect);
        }

        // GET por Id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetInvestigador_Proyecto(int id)
        {
            var Investigador_Proyectos = await _context.Investigador_Proyectos
                .Include(ar => ar.Investigadoress)
                .Include(ar => ar.ProyectoInvestigaciones)
                .FirstOrDefaultAsync(ar => ar.Id == id);

            if (Investigador_Proyectos == null)
            {
                return NotFound();
            }

            return Ok(Investigador_Proyectos);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteInvestigatorProyect(int id)
        {
            var Investigador_Proyecto = await _context.Investigador_Proyectos.FindAsync(id);
            if (Investigador_Proyecto == null)
            {
                return NotFound();
            }

            _context.Investigador_Proyectos.Remove(Investigador_Proyecto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

