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
        public async Task<ActionResult>Post(Investigador Investigadores)
        {
            _context.Add(Investigadores);
            await _context.SaveChangesAsync();
            return Ok(Investigadores);
        }

        [HttpGet("id:int")]
        public async Task<ActionResult>Get(int id)
        {

            var Investigadores = await
                _context.Investigadores.FirstOrDefaultAsync(x => x.Id
                == id);
            if (Investigadores == null)
            {
                return NotFound();
            }
            return Ok(Investigadores);
        }

        [HttpPut]
        public async Task<ActionResult>Put(Investigador Investigadores)
        {
            _context.Update(Investigadores);
            await _context.SaveChangesAsync();
            return Ok(Investigadores);
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
