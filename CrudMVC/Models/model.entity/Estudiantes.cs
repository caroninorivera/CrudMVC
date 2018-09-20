using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.model.entity
{
    //Realiza la herencia a usuarios
    public class Estudiantes : Usuarios
    {
        //Creamos los atributos de la clase
        private string titulo;
        private int estado;
        //constructor vacío
        public Estudiantes()
        {

        }

        //constructor atributos
        public Estudiantes(string Titulo)
        {
            this.Titulo = Titulo;
        }

        //getter
        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public int Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}
