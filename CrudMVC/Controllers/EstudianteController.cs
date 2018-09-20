using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model.entity;
using model.neg;

namespace CrudMVC.Controllers
{
    public class EstudianteController : Controller
    {
        private EstudianteNeg objEstudianteNeg;
        public EstudianteController()
        {
            objEstudianteNeg = new EstudianteNeg();
        }
        // GET: Estudiante, vista para listar todos los estudiantes
        public ActionResult Inicio()
        {
            List<Estudiantes> lista = objEstudianteNeg.findAll();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Create()
        {
            mensajeInicio();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Estudiantes objEstudiante)
        {
            mensajeInicio();
            objEstudianteNeg.create(objEstudiante);
            mensajeErrorRegistro(objEstudiante);
            return View();
        }
        [HttpGet]
        public ActionResult Update(Estudiantes objEstudiante)
        {
            mensajeInicio();
            return View();
        }
        //[HttpPost]
        //public ActionResult Update(Estudiantes objEstudiante)
        //{
        //    mensajeInicio();
        //    objEstudianteNeg.update(objEstudiante);
        //    mensajeErrorRegistro(objEstudiante);
        //    return View();
        //}
        public void mensajeInicio()
        {
            ViewBag.mensajeInicio = "Formulario de Registro de Estudiantes";
        }
        public void mensajeErrorRegistro(Estudiantes objEstudiante)
        {
            switch (objEstudiante.Estado)
            {
                case 10:
                    ViewBag.mensajeError = "Campo Identificación está vacío";
                    break;
                case 1:
                    ViewBag.mensajeError = "La identificación debe tener entre 1 y 20 caracteres únicamente";
                    break;
                case 20:
                    ViewBag.mensajeError = "Campo Nombre está vacío";
                    break;
                case 2:
                    ViewBag.mensajeError = "El Nombre debe tener entre 1 y 100 caracteres únicamente";
                    break;
                case 30:
                    ViewBag.mensajeError = "Campo Apellido está vacío";
                    break;
                case 3:
                    ViewBag.mensajeError = "El apellido debe tener entre 1 y 100 caracteres únicamente";
                    break;
                case 40:
                    ViewBag.mensajeError = "Campo Teléfono está vacío";
                    break;
                case 4:
                    ViewBag.mensajeError = "El Teléfono debe tener entre 1 y 100 caracteres únicamente";
                    break;
                case 50:
                    ViewBag.mensajeError = "Campo Dirección está vacío";
                    break;
                case 5:
                    ViewBag.mensajeError = "La Dirección debe tener entre 1 y 100 caracteres únicamente";
                    break;
                case 60:
                    ViewBag.mensajeError = "Campo Email está vacío";
                    break;
                case 6:
                    ViewBag.mensajeError = "El Email debe tener entre 1 y 100 caracteres únicamente";
                    break;
                case 70:
                    ViewBag.mensajeError = "Campo Usuario está vacío";
                    break;
                case 7:
                    ViewBag.mensajeError = "El Usuario debe tener entre 1 y 20 caracteres únicamente";
                    break;
                case 80:
                    ViewBag.mensajeError = "Campo Contraseña está vacío";
                    break;
                case 8:
                    ViewBag.mensajeError = "La Contraseña debe tener entre 1 y 20 caracteres únicamente";
                    break;
                case 9:
                    ViewBag.mensajeError = "Estudiante [" + objEstudiante.Id_Usuario + "] ya se encuentra registrado en la base de datos";
                    break;
                case 99:
                    ViewBag.mensajeError = "Estudiante [" + objEstudiante.Id_Usuario + "] fue registrado con éxito en la base de datos";
                    break;
            }
        }
    }
}