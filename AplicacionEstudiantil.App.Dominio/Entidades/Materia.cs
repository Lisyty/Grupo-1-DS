using System;

namespace AplicacionEstudiantil.App.Dominio.Entidades{
    public class Materia{
        public int Id { get; set; }
        public string Actividades{get;set;}
        public string Videos{get;set;} 
        public string Trabajos{get;set;}   
        public Profesor Profesor{get;set;}  
    }
}