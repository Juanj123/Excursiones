using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Pojos;
using MySql.Data.MySqlClient;
using MySql.Web;
using System.Data;

namespace Capa_Datos
{
    public class DaoImagen
    {
        cone conec = new cone();
        public bool insertar(PojoImagen pojoImagen)
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conexion();
            cmd.Parameters.AddWithValue("@idImagen", pojoImagen.IdImagen);
            cmd.Parameters.AddWithValue("@idGaleria", pojoImagen.IdGaleria);
            cmd.Parameters.AddWithValue("@titulo", pojoImagen.Titulo);
            cmd.Parameters.AddWithValue("@descripcion", pojoImagen.Descripcion);
            cmd.Parameters.AddWithValue("@url", pojoImagen.Url);
            cmd.Parameters.AddWithValue("@estado", pojoImagen.Estado);
            string consul = "insert into principalImagen(idImagen, idGaleria,titulo,descripcion,url,estado)VALUES(null,@idGaleria,@titulo,@descripcion,@url,@estado)";
            cmd.CommandText = consul;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conec.conectar;
            cmd.ExecuteNonQuery();
            conec.conectar.Close();
            return true;

        }

        public bool modificar(PojoImagen pojoImagen)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conec.conexion();

                cmd.Parameters.AddWithValue("@idImagen", pojoImagen.IdImagen);
                cmd.Parameters.AddWithValue("@idGaleria", pojoImagen.IdGaleria);
                cmd.Parameters.AddWithValue("@titulo", pojoImagen.Titulo);
                cmd.Parameters.AddWithValue("@descripcion", pojoImagen.Descripcion);
                cmd.Parameters.AddWithValue("@url", pojoImagen.Url);
                cmd.Parameters.AddWithValue("@estado", pojoImagen.Estado);

                string consul = "update principalImagen set  idGaleria=@idGaleria, titulo=@titulo, descripcion=@descripcion, url=@url, estado=@estado where idImagen=@idImagen";
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
                cmd.CommandText = "delete from principalImagen where idImagen = @id";
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
                sql = "select idGaleria from galeria where titulo like '" + nombre.ToString() + "'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = dr.GetInt32("idGaleria");
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

        public int obtenerIDImagen(string nombre)
        {
            int id = 0;
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                sql = "select idImagen from principalImagen where titulo like '" + nombre.ToString() + "'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = dr.GetInt32("idImagen");
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

        public List<PojoImagen> obtenerImagen()
        {

            try
            {

                List<PojoImagen> concep = new List<PojoImagen>();
                PojoImagen pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                string sql = " select titulo, descripcion, url,estado from principalImagen";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoImagen();
                    pojoAmbu.Titulo = dr.GetString("titulo");
                    pojoAmbu.Descripcion = dr.GetString("descripcion");
                    pojoAmbu.Estado = dr.GetString("estado");
                    pojoAmbu.Url = dr.GetString("url");
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
