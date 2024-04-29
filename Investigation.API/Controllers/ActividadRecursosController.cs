using Investigation.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Investigation.Shared.Entities;

namespace Investigation.API.Controllers
{
    [ApiController]
    [Route("/api/Actividad_Recurso")]
    public class ActividadRecursosController : ControllerBase
    { 
        private readonly DataContext _context;

        public ActividadRecursosController(DataContext context)
        {
        _context = context;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult> GetActividad_Recurso()
        {
            var Actividad_Recursos = await _context.Actividad_Recursos
                .Include(ar => ar.ActividadesInvestigaciones)
                .Include(ar => ar.RecursosEspecializadoss)
                .ToListAsync();
            return Ok(Actividad_Recursos);
        }

        // POST
        [HttpPost]
        public async Task<ActionResult> Post(int Id_Actividad, int Id_Recurso)
        {
            var resource = await _context.RecursosEspecializados.FindAsync(Id_Recurso);
            var activity = await _context.ActividadesInvestigaciones.FindAsync(Id_Actividad);

                if (resource == null)
                {
                    return NotFound("Recurso no encontrado");
                }
                if (activity == null)
                {
                    return NotFound("Actividad no encontrado");
                }

            var idActivityResource = new Actividad_Recurso
                {
                     ActividadesInvestigaciones = activity,
                     RecursosEspecializadoss =  resource

                };

                _context.Actividad_Recursos.Add(idActivityResource);
                await _context.SaveChangesAsync();

            return Ok(idActivityResource);
        }

        // GET por Id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetActividad_Recurso(int id)
        {
            var activityResource = await _context.Actividad_Recursos
                .Include(ar => ar.ActividadesInvestigaciones)
                .Include(ar => ar.RecursosEspecializadoss)
                .FirstOrDefaultAsync(ar => ar.Id == id);

                     if (activityResource == null)
                     {
                        return NotFound();
                     }

            return Ok(activityResource);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteActivityResource(int id)
        {
                var activityResource = await _context.Actividad_Recursos.FindAsync(id);
                    if (activityResource == null)
                    {
                        return NotFound();
                    }

                _context.Actividad_Recursos.Remove(activityResource);
                await _context.SaveChangesAsync();

                return NoContent();
        }
    }
}
