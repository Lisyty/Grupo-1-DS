using AplicacionEstudiantil.App.Dominio.Entidades;
using System.Collections.Generic;

namespace AplicacionEstudiantil.App.Persistencia{

    public interface IRepositorioEstudiante{
        Estudiante AddEstudiante(Estudiante estudiante);//crear estudiante
        IEnumerable<Estudiante> GetAllEstudiantes(); //consultar tabla general hacia la tabla estudiante
        Estudiante GetEstudiante (int idEstudiante); // COnsulta individual de estudiante
        Estudiante UpdateEstudiante(Estudiante estudiante);//Actualizar Estudainte 
        void DeleteEstudiante(int idEstudiante);//Eliminacion de estudiante  
    }
}