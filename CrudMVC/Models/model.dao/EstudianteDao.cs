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
    public class EstudianteDao : Obligatorio<Estudiantes>
    {
        private Conexion objConexion;
        private SqlCommand comando;

        //constructor
        public EstudianteDao()
        {
            //Acá se cumple el patron Singleton no se puede instanciar esa clase 
            //sólo se instancia a través de sus métodos estáticos
            //objConexion = new Conexion();--Al tener esto marca error no es accesible debido a su nivel de protección
            objConexion = Conexion.saberEstado();
        }

        public void create(Estudiantes objEstudiantes)
        {
            string create = "insert into Usuarios (Id_Usuario, Nombre, Apellido, Telefono, Direccion, Email, Usuario, Contrasena, Perfil) " +
                            "values ('" + objEstudiantes.Id_Usuario + "', '" + objEstudiantes.Nombre + "', '" + objEstudiantes.Apellido +
                            "','" + objEstudiantes.Telefono + "', '" + objEstudiantes.Direccion + "', '" + objEstudiantes.Email +
                            "', '" + objEstudiantes.Usuario + "','" + objEstudiantes.Contraseña + "', 'Estudiante') " +
                            " insert into Estudiantes (Id_Estudiante, Titulo) values ('" + objEstudiantes.Id_Usuario + 
                            "', '" + objEstudiantes.Titulo + "')";
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

        public void update(Estudiantes objEstudiantes)
        {
            string update = "update Usuarios set Nombre = '" + objEstudiantes.Nombre + "', Apellido = '" + objEstudiantes.Apellido +
                            "', Telefono = '" + objEstudiantes.Telefono + "', Direccion = '" + objEstudiantes.Direccion + "', Email = '" +
                            objEstudiantes.Email + "', Usuario = '" + objEstudiantes.Usuario + "', Contrasena = '" + objEstudiantes.Contraseña +
                            "', Perfil = 'Estudiante' where Id_Usuario = '" + objEstudiantes.Id_Usuario + "' " +
                            " update Estudiantes set Titulo = '" + objEstudiantes.Titulo + "' where Id_Estudiante = '" + objEstudiantes.Id_Usuario + "'";
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

        public void delete(Estudiantes objEstudiantes)
        {
            string delete = "delete from Usuarios where Id_Usuario = '" + objEstudiantes.Id_Usuario + "' " +
                            " delete from Estudiantes where Id_Estudiante = '" + objEstudiantes.Id_Usuario + "'";
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

        public bool find(Estudiantes objEstudiantes)
        {
            bool hayRegistros;
            string find = "select U.Id_Usuario, U.Nombre, U.Apellido, E.Titulo, U.Telefono, U.direccion, U.Email " +
                          "from Estudiantes E inner join Usuarios U on U.Id_Usuario = E.Id_Estudiante where U.Id_Usuario = '" + objEstudiantes.Id_Usuario + "'";
            try
            {
                comando = new SqlCommand(find, objConexion.getCon());
                objConexion.getCon().Open();
                SqlDataReader read = comando.ExecuteReader();
                hayRegistros = read.Read();
                if (hayRegistros)
                {
                    objEstudiantes.Id_Usuario = read[0].ToString();
                    objEstudiantes.Nombre = read[1].ToString();
                    objEstudiantes.Apellido = read[2].ToString();
                    objEstudiantes.Titulo = read[3].ToString();
                    objEstudiantes.Telefono = read[4].ToString();
                    objEstudiantes.Direccion = read[5].ToString();
                    objEstudiantes.Email = read[6].ToString();
                    objEstudiantes.Estado = 99;
                }
                else
                {
                    objEstudiantes.Estado = 1;
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

        public List<Estudiantes> findAll()
        {
            List<Estudiantes> listaEstudiantes = new List<Estudiantes>();
            string findAll = "select U.Id_Usuario, U.Nombre, U.Apellido, E.Titulo, U.Telefono, U.direccion, U.Email " +
                          "from Estudiantes E inner join Usuarios U on U.Id_Usuario = E.Id_Estudiante";
            try
            {
                comando = new SqlCommand(findAll, objConexion.getCon());
                objConexion.getCon().Open();
                SqlDataReader read = comando.ExecuteReader();
                while (read.Read())
                {
                    Estudiantes objEstudiantes = new Estudiantes();
                    objEstudiantes.Id_Usuario = read[0].ToString();
                    objEstudiantes.Nombre = read[1].ToString();
                    objEstudiantes.Apellido = read[2].ToString();
                    objEstudiantes.Titulo = read[3].ToString();
                    objEstudiantes.Telefono = read[4].ToString();
                    objEstudiantes.Direccion = read[5].ToString();
                    objEstudiantes.Email = read[6].ToString();
                    listaEstudiantes.Add(objEstudiantes);
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
            return listaEstudiantes;
        }
    }
}
