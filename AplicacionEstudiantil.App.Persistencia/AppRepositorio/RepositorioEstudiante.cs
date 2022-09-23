using System;
using System.Linq;
using System.Collections.Generic;
using AplicacionEstudiantil.App.Dominio.Entidades;


namespace AplicacionEstudiantil.App.Persistencia{
    public class RepositorioEstudiante:IRepositorioEstudiante{

        private readonly AppContext _appContext=new AppContext();

        public Estudiante AddEstudiante(Estudiante estudiante){
            var estudianteAdicionado = _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity;
        }

        public IEnumerable<Estudiante> GetAllEstudiantes(){
            return _appContext.Estudiantes;
        }
        
        public Estudiante GetEstudiante (int idEstudiante){
            return _appContext.Estudiantes.FirstOrDefault(p=> p.Id==idEstudiante);
        }

        public Estudiante UpdateEstudiante(Estudiante estudiante){
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.Id == estudiante.Id);
            if(estudianteEncontrado != null){
                estudianteEncontrado.Nombres=estudiante.Nombres;
                estudianteEncontrado.Apellidos=estudiante.Apellidos;
                estudianteEncontrado.DocumentoIdentidad=estudiante.DocumentoIdentidad;
                estudianteEncontrado.Edad=estudiante.Edad;
                estudianteEncontrado.Correo=estudiante.Correo;
                estudianteEncontrado.Contraseña=estudiante.Contraseña;
                estudianteEncontrado.Grado=estudiante.Grado;    
                
                _appContext.SaveChanges();
            }
            return estudianteEncontrado;
        }

        public void DeleteEstudiante(int idEstudiante){
            var estudianteEncontrado= _appContext.Estudiantes.FirstOrDefault(p => p.Id==idEstudiante);
            if(estudianteEncontrado==null)
            return; 
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
            
        }

        
    }
}
