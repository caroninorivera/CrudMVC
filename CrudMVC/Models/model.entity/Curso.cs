using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Curso 
    {
        private string _Id_Curso;
        private string _Nombre_Curso;
        public string Id_Curso
        {
            get
            {
                return _Id_Curso;
            }

            set
            {
                _Id_Curso = value;
            }
        }
        public string Nombre_Curso
        {
            get
            {
                return _Nombre_Curso;
            }

            set
            {
                _Nombre_Curso = value;
            }
        }        
        //constructores
        public Curso()
        {

        }

        public Curso(string Id_Curso, string Nombre_Curso)
        {
            _Id_Curso = Id_Curso;
            _Nombre_Curso= Nombre_Curso;
        }
    }
}