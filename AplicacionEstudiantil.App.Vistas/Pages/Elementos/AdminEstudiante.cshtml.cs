using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AplicacionEstudiantil.App.Persistencia.AppRepositorio;
using AplicacionEstudiantil.App.Dominio.Entidades;

namespace Ejemplo.Pages
{
    public class AdminEstudianteModel : PageModel
    {
        private readonly IRepositorioEstudiante RepositorioEstudiante;
       
        public List <Estudiante> Estudiante {get; set;}

        public AdminEstudianteModel(IRepositorioEstudiante RepositorioEstudiante){

         this.RepositorioEstudiante= RepositorioEstudiante; 
         }

        public void OnGet(int IdEstudiante);   
        {
            Estudiante=new List<Estudiante>();
            Estudiante=RepositorioEstudiante.GetAllEstudiante();
            RepositorioEstudiante.DeleteEstudiante(IdEstudiante);    
        } 
    }
}