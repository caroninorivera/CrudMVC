using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Materia 
    {
        private string _Id_Materia;
        private string _Nombre_Materia;
        public string Id_Materia
        {
            get
            {
                return _Id_Materia;
            }

            set
            {
                _Id_Materia = value;
            }
        }
        public string Nombre_Materia
        {
            get
            {
                return _Nombre_Materia;
            }

            set
            {
                _Nombre_Materia = value;
            }
        }        
        //constructores
        public Materia()
        {

        }

        public Materia(string Id_Materia, string Nombre_Materia)
        {
            _Id_Materia = Id_Materia;
            _Nombre_Materia= Nombre_Materia;
        }
    }
}