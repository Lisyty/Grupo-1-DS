using System;

namespace AplicacionEstudiantil.App.Dominio.Entidades{
    public class Estudiante:Perfil{
        public string Grado{get;set;}
        public Materia Materia{get;set;}
    }
}