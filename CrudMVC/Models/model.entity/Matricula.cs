using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Matricula 
    {
        private string _Id_Matricula;
        
        public string Id_Matricula
        {
            get
            {
                return _Id_Matricula;
            }

            set
            {
                _Id_Matricula = value;
            }
        }
                
        //constructores
        public Matricula()
        {

        }

        public Matricula(string Id_Matricula)
        {
            _Id_Matricula = Id_Matricula;
        }
    }
}