using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Profesor : Persona
    {
        private string _Id_Profesor;
        private string _Titulo;
        public string Id_Profesor
        {
            get
            {
                return _Id_Profesor;
            }

            set
            {
                _Id_Profesor = value;
            }
        }
        public string Titulo
        {
            get
            {
                return _Titulo;
            }

            set
            {
                _Titulo = value;
            }
        }        
        //constructores
        public Profesor()
        {

        }

        public Profesor(string Id_Profesor, string Titulo)
        {
            _Id_Profesor = Id_Profesor;
            _Titulo = Titulo;
        }
    }
}