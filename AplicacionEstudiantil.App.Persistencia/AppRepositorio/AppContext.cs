using Microsoft.EntityFrameworkCore;
using AplicacionEstudiantil.App.Dominio.Entidades;

namespace AplicacionEstudiantil.App.Persistencia{
    public class AppContext : DbContext{
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (Localdb)\\MSSQLLocalDB; Initial Catalog = AplicacionEducativa_Equipo_1");
            }
        }
    }
}
