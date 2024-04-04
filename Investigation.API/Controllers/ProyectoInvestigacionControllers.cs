using Investigation.API.Data;
using Investigation.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Controllers
{
    [ApiController]
    [Route("/api/ProyectoInvestigacion")]
    public class ProyectoInvestigacionControllers:ControllerBase
    {
        private readonly DataContext _context;

        public ProyectoInvestigacionControllers(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.ActividadesInvestigaciones.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(ActividadesInvestigacion actividadesInvestigaciones)
        {
            _context.Add(actividadesInvestigaciones);
            await _context.SaveChangesAsync();
            return Ok(actividadesInvestigaciones);
        }

        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {

            var actividadesInvestigacion = await
                _context.ActividadesInvestigaciones.FirstOrDefaultAsync(x => x.Id
                == id);
            if (actividadesInvestigacion == null)
            {
                return NotFound();
            }
            return Ok(actividadesInvestigacion);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ActividadesInvestigacion actividadesInvestigacion)
        {
            _context.Add(actividadesInvestigacion);
            await _context.SaveChangesAsync();
            return Ok(actividadesInvestigacion);
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {

            var Filasafectadas = await _context.ActividadesInvestigaciones

                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (Filasafectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
