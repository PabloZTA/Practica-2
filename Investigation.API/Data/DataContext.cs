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
        public DbSet<Publicacion> Publicacion {  get; set; }
        public DbSet<ActividadesInvestigacion> ActividadesInvestigacion { get; set; }
        public DbSet<RecursosEspecializados> RecurdosEspecializados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
