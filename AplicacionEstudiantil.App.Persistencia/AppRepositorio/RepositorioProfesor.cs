using System.Collections;
using System.Security.AccessControl;
using System;
using System.Linq;
using System.Collections.Generic;
using AplicacionEstudiantil.App.Dominio.Entidades;
    
namespace AplicacionEstudiantil.App.Persistencia{
    public class RepositorioProfesor:IRepositorioProfesor{

        private readonly AppContext _appContext=new AppContext();
    
        public Profesor AddProfesor(Profesor profesor){
            var profesorAdicionado = _appContext.Profesores.Add(profesor);
            _appContext.SaveChanges();
            return profesorAdicionado.Entity;
        }

        public IEnumerable<Profesor> GetAllProfesor(){
            return _appContext.Profesores;
        }

        public Profesor GetProfesor (int idProfesor){
            return _appContext.Profesores.FirstOrDefault(p=> p.Id==idProfesor);
        }

        public Profesor UpdateProfesor(Profesor profesor){
            var profesorEncontrado = _appContext.Profesores.FirstOrDefault(p => p.Id == profesor.Id);
            if(profesorEncontrado != null){
                profesorEncontrado.Nombres=profesor.Nombres;
                profesorEncontrado.Apellidos=profesor.Apellidos;
                profesorEncontrado.DocumentoIdentidad=profesor.DocumentoIdentidad;
                profesorEncontrado.Edad=profesor.Edad;
                profesorEncontrado.Correo=profesor.Correo;
                profesorEncontrado.Contraseña=profesor.Contraseña;
                profesorEncontrado.GrupoAcademico=profesor.GrupoAcademico;

                _appContext.SaveChanges();
            }
            return profesorEncontrado;
        }

        public void DeleteProfesor(int idProfesor){
            var profesorEncontrado= _appContext.Profesores.FirstOrDefault(p => p.Id==idProfesor);
            if(profesorEncontrado==null)
            return; 
            _appContext.Profesores.Remove(profesorEncontrado);
            _appContext.SaveChanges();
            
        }
    }
}