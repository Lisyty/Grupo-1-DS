using System.Collections;
using AplicacionEstudiantil.App.Dominio.Entidades;
using System.Collections.Generic;

namespace AplicacionEstudiantil.App.Persistencia
{
    public interface IRepositorioProfesor{
        Profesor AddProfesor(Profesor profesor);
        IEnumerable<Profesor> GetAllProfesor();
        Profesor GetProfesor (int idProfesor);
        Profesor UpdateProfesor(Profesor profesor);
        void DeleteProfesor(int idProfesor);
    }
}