using Investigation.API.Controllers;
using Investigation.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Investigation.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
        } 

        public DbSet<Investigadores>Investigadoress {  get; set; }
        public DbSet<ProyectoInvestigacion>ProyectoInvestigaciones { get; set; }
        public DbSet<Publicacion> Publicaciones {  get; set; }
        public DbSet<ActividadesInvestigacion> ActividadesInvestigaciones { get; set; }
        public DbSet<RecursosEspecializados> RecursosEspecializados { get; set; }
        public DbSet<Actividad_Recurso> Actividad_Recursos {  get; set; }
        public DbSet<Investigador_Proyecto> Investigador_Proyectos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
