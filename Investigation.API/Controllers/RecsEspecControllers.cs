using Investigation.API.Data;
using Investigation.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Controllers
{

    [ApiController]
    [Route("/api/RecursosEspecializados")]
    public class RecsEspecControllers : ControllerBase
    {
        private readonly DataContext _context;

        public RecsEspecControllers(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.RecurdosEspecializados.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(RecursosEspecializados recursosEspecializados)
        {
            _context.Add(recursosEspecializados);
            await _context.SaveChangesAsync();
            return Ok(recursosEspecializados);
        }


        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {

            var recursosEspecializados = await
                _context.RecurdosEspecializados.FirstOrDefaultAsync(x => x.Id
                == id);
            if (recursosEspecializados == null)
            {
                return NotFound();
            }
            return Ok(recursosEspecializados);
        }

        [HttpPut]
        public async Task<ActionResult> Put(RecursosEspecializados recursosEspecializados)
        {
            _context.Add(recursosEspecializados);
            await _context.SaveChangesAsync();
            return Ok(recursosEspecializados);
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {

            var Filasafectadas = await _context.RecurdosEspecializados

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
