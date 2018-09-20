using CrudMVC.Models;
using model.dao;
using model.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.model.dao
{
    public class MateriaDao : Obligatorio<Materias>
    {
        private Conexion objConexion;
        private SqlCommand comando;

        //constructor
        public MateriaDao()
        {
            //Acá se cumple el patron Singleton no se puede instanciar esa clase 
            //sólo se instancia a través de sus métodos estáticos
            //objConexion = new Conexion();--Al tener esto marca error no es accesible debido a su nivel de protección
            objConexion = Conexion.saberEstado();
        }

        public void create(Materias objMaterias)
        {
            string create = " insert into Materias (Id_Materia, Nombre_Materia_Materia) values ('" + objMaterias.Id_Materia + 
                            "', '" + objMaterias.Nombre_Materia + "')";
            try
            {
                comando = new SqlCommand(create, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }
        }

        public void update(Materias objMaterias)
        {
            string update = "update Usuarios set Nombre_Materia_Materia where Id_Materia = '" + objMaterias.Id_Materia + "'";
            try
            {
                comando = new SqlCommand(update, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }
        }

        public void delete(Materias objMaterias)
        {
            string delete = " delete from Materias where Id_Materia = '" + objMaterias.Id_Materia + "'";
            try
            {
                comando = new SqlCommand(delete, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }
        }

        public bool find(Materias objMaterias)
        {
            bool hayRegistros;
            string find = "select Id_Materia, Nombre_Materia_Materia" +
                          "from Materias Id_Materia = '" + objMaterias.Id_Materia + "'";
            try
            {
                comando = new SqlCommand(find, objConexion.getCon());
                objConexion.getCon().Open();
                SqlDataReader read = comando.ExecuteReader();
                hayRegistros = read.Read();
                if (hayRegistros)
                {
                    objMaterias.Id_Materia = read[0].ToString();
                    objMaterias.Nombre_Materia = read[1].ToString();
                }
                else
                {
                    //objMaterias.Estado = 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }
            return hayRegistros;
        }

        public List<Materias> findAll()
        {
            List<Materias> listaMaterias = new List<Materias>();
            string findAll = "select Id_Materia, Nombre_Materia_Materia" +
                          "from Materias";
            try
            {
                comando = new SqlCommand(findAll, objConexion.getCon());
                objConexion.getCon().Open();
                SqlDataReader read = comando.ExecuteReader();
                while (read.Read())
                {
                    Materias objMaterias = new Materias();
                    objMaterias.Id_Materia = read[0].ToString();
                    objMaterias.Nombre_Materia = read[1].ToString();
                    listaMaterias.Add(objMaterias);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }
            return listaMaterias;
        }
    }
}
