using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Persona
    {
        private string _id_persona;
        private string _perfil;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _direccion;
        private string _email;

        public string Id_persona
        {
            get
            {
                return _id_persona;
            }

            set
            {
                _id_persona = value;
            }
        }

        public string Perfil
        {
            get
            {
                return _perfil;
            }

            set
            {
                _perfil = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }

            set
            {
                _apellido = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }

            set
            {
                _direccion = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        //Consructores
        public Persona()
        {

        }
        public Persona(string Id_persona, string Perfil, string Nombre, string Apellido, string Telefono, string Direccion, string Email)
        {
            _id_persona = Id_persona;
            _perfil = Perfil;
            _nombre = Nombre;
            _apellido = Apellido;
            _telefono = Telefono;
            _direccion = Direccion;
            _email = Email;
        }
    }
}