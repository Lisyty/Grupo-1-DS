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
                optionsBuilder.UseSqlServer("Data Source=SQL8002.site4now.net;Initial Catalog=db_a8d4e8_dijaliyo001;User Id=db_a8d4e8_dijaliyo001_admin;Password=MISIONES-tic2022"");//conexion a base de datos local
            }
        }
    }
}
