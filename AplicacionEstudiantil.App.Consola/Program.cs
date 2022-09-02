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
            Console.WriteLine("Hello World!");
            //AgregarEstudiante();
            BuscarEstudiante(1);
        }

        private static void AgregarEstudiante(){
            var estudiante = new Estudiante
            {
                Nombres="Alfredo Alfredo",
                Apellidos="Marin Marin",
                DocumentoIdentidad="1030527185",
                Edad="18",
                Correo="YohanALfredo@gmail.com",
                Contraseña="1dead",
                Grado="quinto",
                
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
