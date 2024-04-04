using Investigation.API.Data;
using Investigation.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Controllers
{
    [ApiController]
    [Route("/api/ActividadesInvestigacion")]
    public class ActividadesInvestigacionControllers:ControllerBase
    {
        private readonly DataContext _context;

        public ActividadesInvestigacionControllers(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.ActividadesInvestigacion.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(ActividadesInvestigacion actividadesInvestigacion)
        {
            _context.Add(actividadesInvestigacion);
            await _context.SaveChangesAsync();
            return Ok(actividadesInvestigacion);
        }

        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {

            var actividadesInvestigacion = await
                _context.ActividadesInvestigacion.FirstOrDefaultAsync(x => x.Id
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

            var Filasafectadas = await _context.ActividadesInvestigacion

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
