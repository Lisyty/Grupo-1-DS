using System;
using AplicacionEstudiantil.App.Persistencia;
using AplicacionEstudiantil.App.Dominio.Entidades;
using System.Collections.Generic;

namespace AplicacionEstudiantil.App.Consola
{
    class Program
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext()); 
        static void Main(string[] args)
        {
            AgregarEstudiante();
            //BuscarEstudiante(2);
            Console.WriteLine("Hello World!");
        }

        private static void AgregarEstudiante(){
            var estudiante = new Estudiante
            {
                Nombres="juan ",
                Apellidos="gonzles",
                DocumentoIdentidad="1111185",
                Edad="13",
                Correo="dipamato@gmail.com",
                Contraseña="jdeededi3i",
                Grado="tercero",   
            };
        _repoEstudiante.AddEstudiante(estudiante);   
        }   

        private static void BuscarEstudiante(int idEstudiante)
        {
            var estudiante = _repoEstudiante.GetEstudiante(idEstudiante);
            Console.WriteLine(estudiante.Nombres + " " + estudiante.Apellidos  + " " + estudiante.Grado );
        }
    }
}
