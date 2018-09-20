using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Calificacion 
    {
        private string _Id_Calificacion;
        private int _Corte1;
	private int _Corte2;
	private int _Corte3;
        public string Id_Calificacion
        {
            get
            {
                return _Id_Calificacion;
            }

            set
            {
                _Id_Calificacion = value;
            }
        }
        public int Corte1
        {
            get
            {
                return _Corte1;
            }

            set
            {
                _Corte1 = value;
            }
        }
        
	public int Corte2
        {
            get
            {
                return _Corte2;
            }

            set
            {
                _Corte2 = value;
            }
        }
 	public int Corte3
        {
            get
            {
                return _Corte3;
            }

            set
            {
                _Corte3 = value;
            }
        }
        //constructores
        public Calificacion()
        {

        }

       
    }
}