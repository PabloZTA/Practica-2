using Investigation.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {


        } 

        public DbSet<Investigadores>Investigadores {  get; set; }
        public DbSet<ProyectoInvestigacion> ProyectoInvestigacion { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
     
        
    }
}
