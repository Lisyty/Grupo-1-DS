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
    public class AdminProfesorModel : PageModel
    {
        private readonly IRepositorioProfesor _repoProfesor;
        private readonly IRepositorioEstudiante _repoEstudiante;

        /*public AdminProfesorModel(IRepositorioProfesor repoProfesor){
            _repoProfesor=repoProfesor;
        }*/

        public IEnumerable<Estudiante> listaEstudiantes{get;set;}

        public AdminProfesorModel(IRepositorioEstudiante repoEstudiante){
            _repoEstudiante=repoEstudiante;
        }
        public void OnGet()
        {
            listaEstudiantes= new List<Estudiante>();
            listaEstudiantes=_repoEstudiante.GetAllEstudiantes();
        }
    }
}
