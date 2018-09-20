using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model.dao;
using model.entity;
using Models.model.dao;

namespace Models.model.neg
{
    public class EstudianteNeg
    {
        //Se crea el objeto para llamar los métodos de la clase Dao
        private EstudianteDao objEstudianteDao;
        public EstudianteNeg()
        {
            objEstudianteDao = new EstudianteDao();
        }
        public void create(Estudiantes objEstudiante)
        {
            bool verificacion;
            //validar idEstudiante estado = 1
            string codigo = objEstudiante.Id_Usuario.ToString();
            if (codigo == null)
            {
                objEstudiante.Estado = 10;
                return;
            }
            else
            {
                codigo = objEstudiante.Id_Usuario.Trim();
                verificacion = codigo.Length > 0 && codigo.Length <= 20;
                if (!verificacion)
                {
                    objEstudiante.Estado = 1;
                    return;
                }
            }
            //validar nombre estudiante estado = 2
            string nombre = objEstudiante.Nombre;
            if(nombre == null)
            {
                objEstudiante.Estado = 20;
                return;
            }
            else
            {
                nombre = objEstudiante.Nombre.Trim();
                verificacion = nombre.Length > 0 && nombre.Length <= 100;
                if(!verificacion)
                {
                    objEstudiante.Estado = 2;
                    return;
                }
            }
            //validar apellido estudiante estado = 3
            string apellido = objEstudiante.Apellido;
            if (apellido == null)
            {
                objEstudiante.Estado = 30;
                return;
            }
            else
            {
                apellido = objEstudiante.Apellido.Trim();
                verificacion = apellido.Length > 0 && apellido.Length <= 100;
                if (!verificacion)
                {
                    objEstudiante.Estado = 3;
                    return;
                }
            }
            //validar teléfono estudiante estado = 4
            string telefono = objEstudiante.Telefono;
            if (telefono == null)
            {
                objEstudiante.Estado = 40;
                return;
            }
            else
            {
                telefono = objEstudiante.Telefono.Trim();
                verificacion = telefono.Length > 0 && telefono.Length <= 100;
                if (!verificacion)
                {
                    objEstudiante.Estado = 4;
                    return;
                }
            }
            //validar dirección estudiante estado = 5
            string direccion = objEstudiante.Direccion;
            if (direccion == null)
            {
                objEstudiante.Estado = 50;
                return;
            }
            else
            {
                direccion = objEstudiante.Direccion.Trim();
                verificacion = direccion.Length > 0 && direccion.Length <= 100;
                if (!verificacion)
                {
                    objEstudiante.Estado = 5;
                    return;
                }
            }
            //validar email estudiante estado = 6
            string email = objEstudiante.Email;
            if (email == null)
            {
                objEstudiante.Estado = 60;
                return;
            }
            else
            {
                email = objEstudiante.Email.Trim();
                verificacion = email.Length > 0 && email.Length <= 100;
                if (!verificacion)
                {
                    objEstudiante.Estado = 6;
                    return;
                }
            }
            //validar usuario estudiante estado = 7
            string usuario = objEstudiante.Usuario;
            if (usuario == null)
            {
                objEstudiante.Estado = 70;
                return;
            }
            else
            {
                usuario = objEstudiante.Usuario.Trim();
                verificacion = usuario.Length > 0 && usuario.Length <= 20;
                if (!verificacion)
                {
                    objEstudiante.Estado = 7;
                    return;
                }
            }
            //validar contraseña estudiante estado = 8
            string contrasena = objEstudiante.Contraseña;
            if (contrasena == null)
            {
                objEstudiante.Estado = 80;
                return;
            }
            else
            {
                contrasena = objEstudiante.Contraseña.Trim();
                verificacion = contrasena.Length > 0 && contrasena.Length <= 20;
                if (!verificacion)
                {
                    objEstudiante.Estado = 8;
                    return;
                }
            }
            //validar que estudiante no esté repetido estado = 9
            Estudiantes objEstudianteAux = new Estudiantes();
            objEstudianteAux.Id_Usuario = objEstudiante.Id_Usuario;
            verificacion = !objEstudianteDao.find(objEstudianteAux);
            if (!verificacion)
            {
                objEstudiante.Estado = 9;
                return;
            }
            //Si no tiene ningún error debe hacer lo siguiente
            objEstudiante.Estado = 99;
            objEstudianteDao.create(objEstudiante);
        }
        public void update(Estudiantes objEstudiante)
        {
            bool verificacion;
            //validar nombre estudiante estado = 2
            string nombre = objEstudiante.Nombre;
            if (nombre == null)
            {
                objEstudiante.Estado = 20;
                return;
            }
            else
            {
                nombre = objEstudiante.Nombre.Trim();
                verificacion = nombre.Length > 0 && nombre.Length <= 100;
                if (!verificacion)
                {
                    objEstudiante.Estado = 2;
                    return;
                }
            }
            //validar apellido estudiante estado = 3
            string apellido = objEstudiante.Apellido;
            if (apellido == null)
            {
                objEstudiante.Estado = 30;
                return;
            }
            else
            {
                apellido = objEstudiante.Apellido.Trim();
                verificacion = apellido.Length > 0 && apellido.Length <= 100;
                if (!verificacion)
                {
                    objEstudiante.Estado = 3;
                    return;
                }
            }
            //validar teléfono estudiante estado = 4
            string telefono = objEstudiante.Telefono;
            if (telefono == null)
            {
                objEstudiante.Estado = 40;
                return;
            }
            else
            {
                telefono = objEstudiante.Telefono.Trim();
                verificacion = telefono.Length > 0 && telefono.Length <= 100;
                if (!verificacion)
                {
                    objEstudiante.Estado = 4;
                    return;
                }
            }
            //validar dirección estudiante estado = 5
            string direccion = objEstudiante.Direccion;
            if (direccion == null)
            {
                objEstudiante.Estado = 50;
                return;
            }
            else
            {
                direccion = objEstudiante.Direccion.Trim();
                verificacion = direccion.Length > 0 && direccion.Length <= 100;
                if (!verificacion)
                {
                    objEstudiante.Estado = 5;
                    return;
                }
            }
            //validar email estudiante estado = 6
            string email = objEstudiante.Email;
            if (email == null)
            {
                objEstudiante.Estado = 60;
                return;
            }
            else
            {
                email = objEstudiante.Email.Trim();
                verificacion = email.Length > 0 && email.Length <= 100;
                if (!verificacion)
                {
                    objEstudiante.Estado = 6;
                    return;
                }
            }
            //validar usuario estudiante estado = 7
            string usuario = objEstudiante.Usuario;
            if (usuario == null)
            {
                objEstudiante.Estado = 70;
                return;
            }
            else
            {
                usuario = objEstudiante.Usuario.Trim();
                verificacion = usuario.Length > 0 && usuario.Length <= 20;
                if (!verificacion)
                {
                    objEstudiante.Estado = 7;
                    return;
                }
            }
            //validar contraseña estudiante estado = 8
            string contrasena = objEstudiante.Contraseña;
            if (contrasena == null)
            {
                objEstudiante.Estado = 80;
                return;
            }
            else
            {
                contrasena = objEstudiante.Contraseña.Trim();
                verificacion = contrasena.Length > 0 && contrasena.Length <= 20;
                if (!verificacion)
                {
                    objEstudiante.Estado = 8;
                    return;
                }
            }
            //Si no tiene ningún error debe hacer lo siguiente
            objEstudiante.Estado = 99;
            objEstudianteDao.update(objEstudiante);
        }
        //Se verifica que para eliminar el usuario exista en la base de datos
        public void delete(Estudiantes objEstudiante)
        {
            bool verificacion;
            Estudiantes objEstudianteAux = new Estudiantes();
            objEstudianteAux.Id_Usuario = objEstudiante.Id_Usuario;
            verificacion = objEstudianteDao.find(objEstudianteAux);
            if (!verificacion)
            {
                objEstudiante.Estado = 33;
                return;
            }
            //Sí todo salió bien marca el estado de éxito como 99
            objEstudiante.Estado = 99;
            objEstudianteDao.delete(objEstudiante);
        }
        public bool find(Estudiantes objEstudiante)
        {
            return objEstudianteDao.find(objEstudiante);
        }
        public List<Estudiantes> findAll()
        {
            return objEstudianteDao.findAll();
        }
    }
}
