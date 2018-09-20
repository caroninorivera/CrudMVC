using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model.dao;
using model.entity;
using Models.model.dao;
using CrudMVC.Models;

namespace Models.model.neg
{
    public class MateriaNeg
    {
        //Se crea el objeto para llamar los métodos de la clase Dao
        private MateriaDao objMateriaDao;
        public MateriaNeg()
        {
            objMateriaDao = new MateriaDao();
        }
        public void create(Materias objMateria)
        {
            bool verificacion;
            //validar idMateria estado = 1
            string codigo = objMateria.Id_Materia.ToString();
            if (codigo == null)
            {
               // objMateria.Estado = 10;
                return;
            }
            else
            {
                codigo = objMateria.Id_Materia.Trim();
                verificacion = codigo.Length > 0 && codigo.Length <= 20;
                if (!verificacion)
                {
                  //  objMateria.Estado = 1;
                    return;
                }
            }
            //validar Nombre_Materia Materia estado = 2
            string Nombre_Materia = objMateria.Nombre_Materia;
            if(Nombre_Materia == null)
            {
               // objMateria.Estado = 20;
                return;
            }
            else
            {
                Nombre_Materia = objMateria.Nombre_Materia.Trim();
                verificacion = Nombre_Materia.Length > 0 && Nombre_Materia.Length <= 100;
                if(!verificacion)
                {
                    //objMateria.Estado = 2;
                    return;
                }
            }
            //validar que Materia no esté repetido estado = 9
            Materias objMateriaAux = new Materias();
            objMateriaAux.Id_Materia = objMateria.Id_Materia;
            verificacion = !objMateriaDao.find(objMateriaAux);
            if (!verificacion)
            {
               // objMateria.Estado = 9;
                return;
            }
            //Si no tiene ningún error debe hacer lo siguiente
            //objMateria.Estado = 99;
            objMateriaDao.create(objMateria);
        }
        public void update(Materias objMateria)
        {
            bool verificacion;
            //validar Nombre_Materia Materia estado = 2
            string Nombre_Materia = objMateria.Nombre_Materia;
            if (Nombre_Materia == null)
            {
               // objMateria.Estado = 20;
                return;
            }
            else
            {
                Nombre_Materia = objMateria.Nombre_Materia.Trim();
                verificacion = Nombre_Materia.Length > 0 && Nombre_Materia.Length <= 100;
                if (!verificacion)
                {
                    //objMateria.Estado = 2;
                    return;
                }
            }
            
            //Si no tiene ningún error debe hacer lo siguiente
           // objMateria.Estado = 99;
            objMateriaDao.update(objMateria);
        }
        //Se verifica que para eliminar el usuario exista en la base de datos
        public void delete(Materias objMateria)
        {
            bool verificacion;
            Materias objMateriaAux = new Materias();
            objMateriaAux.Id_Materia = objMateria.Id_Materia;
            verificacion = objMateriaDao.find(objMateriaAux);
            if (!verificacion)
            {
                //objMateria.Estado = 33;
                return;
            }
            //Sí todo salió bien marca el estado de éxito como 99
            //objMateria.Estado = 99;
            objMateriaDao.delete(objMateria);
        }
        public bool find(Materias objMateria)
        {
            return objMateriaDao.find(objMateria);
        }
        public List<Materias> findAll()
        {
            return objMateriaDao.findAll();
        }
    }
}
