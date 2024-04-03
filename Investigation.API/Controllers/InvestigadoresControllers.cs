using Investigation.API.Data;
using Investigation.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Controllers
{
    [ApiController]
    [Route("/api/investigadores")]
    public class InvestigadoresControllers:ControllerBase
    {
        private readonly DataContext _context;

        public InvestigadoresControllers(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Investigadores.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult>Post(Investigadores investigadores)
        {
            _context.Add(investigadores);
            await _context.SaveChangesAsync();
            return Ok(investigadores);
        }

        [HttpGet("id:int")]
        public async Task<ActionResult>Get(int id)
        {

            var investigadores = await
                _context.Investigadores.FirstOrDefaultAsync(x => x.Id
                == id);
            if (investigadores == null)
            {
                return NotFound();
            }
            return Ok(investigadores);
        }

        [HttpPut]
        public async Task<ActionResult>Put(Investigadores investigadores)
        {
            _context.Add(investigadores);
            await _context.SaveChangesAsync();
            return Ok(investigadores);
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {
            
            var Filasafectadas = await _context.Investigadores

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
