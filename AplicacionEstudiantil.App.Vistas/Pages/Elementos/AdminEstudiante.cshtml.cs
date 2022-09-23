using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AplicacionEstudiantil.App.Persistencia;
using AplicacionEstudiantil.App.Dominio.Entidades;

namespace AplicacionEstudiantil.App.Vistas.Pages
{
    public class AdminEstudianteModel : PageModel
    {
        //Aqui conecta a los servicios
        //esta es la inicializacion
        private readonly IRepositorioEstudiante _repoEstudiante;

        public IEnumerable<Estudiante> listaEstudiantes{get;set;}

        public AdminEstudianteModel(IRepositorioEstudiante repoEstudiante){
            _repoEstudiante=repoEstudiante;
        }
        public void OnGet()
        {
            listaEstudiantes= new List<Estudiante>();
            listaEstudiantes=_repoEstudiante.GetAllEstudiantes();
        }
    }
}
