using System;

namespace AplicacionEstudiantil.App.Dominio.Entidades{
    public class Perfil{
        public int Id { get; set; }
        public string Nombres{get;set;}
        public string Apellidos{get;set;}
        public string DocumentoIdentidad{get;set;}
        public string Edad{get;set;}
        public string Correo{get;set;} 
        public string Contraseña{get;set;}
    }
}