using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Pojos;
using MySql.Data.MySqlClient;
using MySql.Web;
using System.Data;

namespace Capa_Datos
{
    public class DaoPrincipal
    {
        cone conec = new cone();

        public string insertar(PojoPrincipal pojoPrincipal)
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conexion();
            cmd.Parameters.AddWithValue("@idPrincipal", pojoPrincipal.IdPrincipal);
            cmd.Parameters.AddWithValue("@descripcion", pojoPrincipal.Descripcion);
            cmd.Parameters.AddWithValue("@estado", pojoPrincipal.Estado);
            cmd.Parameters.AddWithValue("@idUsuario", pojoPrincipal.IdUsuario);
            string consul = "insert into principal(idPrincipal, description, estado, idUsuario)VALUES(null,@descripcion, @estado, @idUsuario)";
            cmd.CommandText = consul;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conec.conectar;
            cmd.ExecuteNonQuery();
            conec.conectar.Close();
            return "Guardado";

        }

        public bool modificar(PojoPrincipal Alma)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conec.conexion();

                cmd.Parameters.AddWithValue("@idPrincipal", Alma.IdPrincipal);
                cmd.Parameters.AddWithValue("@idUsuario", Alma.IdUsuario);
                cmd.Parameters.AddWithValue("@descripcion", Alma.Descripcion);
                cmd.Parameters.AddWithValue("@estado", Alma.Estado);
                
                string consul = "update principal set  description=@descripcion, estado=@estado, idUsuario=@idUsuario where idPrincipal=@idPrincipal";
                cmd.CommandText = consul;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conec.conectar;
                cmd.ExecuteNonQuery();

                return true;

            }
            catch
            {
                return true;
            }
            finally
            {
                conec.conectar.Close();
                conec.conectar.Close();
            }

        }

        public bool Eliminar(int id)
        {
            try
            {
                conec.conexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conec.conectar;
                cmd.Parameters.AddWithValue("@id", id.ToString());
                cmd.CommandText = "delete from principal where idPrincipal = @id";
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception exc)
            {
                return false;
            }
            finally
            {
                conec.conectar.Close();
            }

        }

        public int obtenerID(string nombre)
        {
            int id = 0;
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                sql = "select idPrincipal from principal where description like '" + nombre.ToString() + "'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = dr.GetInt32("idPrincipal");
                    return id;
                }
                else
                {

                    return id;
                }
            }
            catch (Exception exc)
            {
                return id;
            }
            finally
            {
                conec.conectar.Close();
            }
        }

        public string obtenerDescripcion(int idPrincipal)
        {
            string id = "";
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                sql = "select description  from principal where idPrincipal like '" + idPrincipal.ToString() + "'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = dr.GetString("description");
                    return id;
                }
                else
                {

                    return id;
                }
            }
            catch (Exception exc)
            {
                return id;
            }
            finally
            {
                conec.conectar.Close();
            }
        }

        public int obtenerIdUsuario(string user)
        {
            int id = 0;
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                sql = "select idUsuario from usuarios where Usuario like '" + user.ToString() + "'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = dr.GetInt32("idUsuario");
                    return id;
                }
                else
                {

                    return id;
                }
            }
            catch (Exception exc)
            {
                return id;
            }
            finally
            {
                conec.conectar.Close();
            }
        }

        public List<PojoPrincipal> obtenerPrincipal()
        {

            try
            {

                List<PojoPrincipal> concep = new List<PojoPrincipal>();
                PojoPrincipal pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                string sql = " select idPrincipal, description, estado from principal";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoPrincipal();
                    pojoAmbu.IdPrincipal = dr.GetInt32("idPrincipal");
                    pojoAmbu.Descripcion = dr.GetString("description");
                    pojoAmbu.Estado = dr.GetString("estado");
                    concep.Add(pojoAmbu);
                }
                return concep;
            }
            catch (Exception exc)
            {
                return null;
            }
            finally
            {
                conec.conectar.Close();
            }
        }

        public List<PojoPrincipal> obtenerDescripcion()
        {

            try
            {

                List<PojoPrincipal> concep = new List<PojoPrincipal>();
                PojoPrincipal pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                string sql = " select description, estado from principal";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoPrincipal();
                    pojoAmbu.Descripcion = dr.GetString("description");
                    pojoAmbu.Estado = dr.GetString("estado");
                    concep.Add(pojoAmbu);
                }
                return concep;
            }
            catch (Exception exc)
            {
                return null;
            }
            finally
            {
                conec.conectar.Close();
            }
        }


    }
}
