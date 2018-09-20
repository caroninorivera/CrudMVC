using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.model.entity
{
    public class Usuarios
    {
        //Creamos los atributos de la clase
        private string id_Usuario;
        private string nombre;
        private string apellido;
        private string telefono;
        private string direccion;
        private string email;
        private string usuario;
        private string contrasena;
        private string perfil;

        //constructor vacío
        public Usuarios()
        {

        }
        //constructor llave primaria
        public Usuarios(string Id_Usuario)
        {
            this.Id_Usuario = Id_Usuario;
        }
        //constructor todos los elementos
        public Usuarios(string Id_Usuario, string Nombre, string Apellido, string Telefono, string Direccion, 
            string Email, string Usuario, string Contrasena, string Perfil)
        {
            this.Id_Usuario = Id_Usuario;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.Email = Email;
            this.Usuario = Usuario;
            this.Contrasena = Contrasena;
            this.Perfil = Perfil;
        }

        //getter
        public string Id_Usuario
        {
            get
            {
                return id_Usuario;
            }

            set
            {
                id_Usuario = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Contrasena
        {
            get
            {
                return contrasena;
            }

            set
            {
                contrasena = value;
            }
        }

        public string Perfil
        {
            get
            {
                return perfil;
            }

            set
            {
                perfil = value;
            }
        }
    }
}
