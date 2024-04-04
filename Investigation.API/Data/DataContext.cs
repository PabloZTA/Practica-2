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
        public DbSet<ProyectoInvestigacion>ProyectoInvestigaciones { get; set; }
        public DbSet<Publicacion> Publicaciones {  get; set; }
        public DbSet<ActividadesInvestigacion> ActividadesInvestigaciones { get; set; }
        public DbSet<RecursosEspecializados> RecursosEspecializados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
