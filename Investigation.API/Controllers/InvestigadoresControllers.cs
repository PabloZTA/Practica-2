using Investigation.API.Data;
using Investigation.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Controllers
{
    [ApiController]
    [Route("/api/Investigadores")]
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
        public async Task<ActionResult>Post(Investigador investigador)
        {
            _context.Add(investigador);
            await _context.SaveChangesAsync();
            return Ok(investigador);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult>Get(int id)
        {

            var investigador = await
                _context.Investigadores.FirstOrDefaultAsync(x => x.Id
                == id);
            if (investigador == null)
            {
                return NotFound();
            }
            return Ok(investigador);
        }

        [HttpPut]
        public async Task<ActionResult>Put(Investigador investigador)
        {
            _context.Update(investigador);
            await _context.SaveChangesAsync();
            return Ok(investigador);
        }

        [HttpDelete("{id:int}")]
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
