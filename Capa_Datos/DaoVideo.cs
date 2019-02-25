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
    public class DaoVideo
    {
        cone conec = new cone();

        public List<PojoVideo> obtenerVideo()
        {

            try
            {

                List<PojoVideo> concep = new List<PojoVideo>();
                PojoVideo pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                string sql = " select * from principalvideo where estado like 'Activo'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoVideo();
                    pojoAmbu.IdVideo = dr.GetInt32("idVideo");
                    pojoAmbu.IdUsuario = dr.GetInt32("idUsuario");
                    pojoAmbu.Nombre = dr.GetString("nombre");
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

        public List<pojoMostrarVideo> obtenerVideos()
        {

            try
            {

                List<pojoMostrarVideo> concep = new List<pojoMostrarVideo>();
                pojoMostrarVideo pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                string sql = " select nombre, estado, url from principalvideo";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new pojoMostrarVideo();
                    pojoAmbu.Nombre = dr.GetString("nombre");
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

        public string insertar(PojoVideo pojoVideo)
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conexion();
            cmd.Parameters.AddWithValue("@idUsuario", pojoVideo.IdUsuario);
            cmd.Parameters.AddWithValue("@nombre", pojoVideo.Nombre);
            cmd.Parameters.AddWithValue("@estado", pojoVideo.Estado);
            cmd.Parameters.AddWithValue("@url", pojoVideo.Url);
            string consul = "insert into principalVideo(idVideo, idUsuario, nombre, estado,url)VALUES(null,@idUsuario,@nombre,@estado,@url)";
            cmd.CommandText = consul;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conec.conectar;
            cmd.ExecuteNonQuery();
            conec.conectar.Close();
            return "Guardado";

        }


        public bool modificar(PojoVideo Alma)
        {
            MySqlCommand cmd = new MySqlCommand();

            try {
                conec.conexion();

                cmd.Parameters.AddWithValue("@idVideo", Alma.IdVideo);
                cmd.Parameters.AddWithValue("@idUsuario", Alma.IdUsuario);
                cmd.Parameters.AddWithValue("@nombre", Alma.Nombre);
                cmd.Parameters.AddWithValue("@estado", Alma.Estado);
                cmd.Parameters.AddWithValue("@url", Alma.Url);
                string consul = "update principalVideo set  idUsuario=@idUsuario, nombre=@nombre, estado=@estado, url=@url where idVideo=@idVideo";
                cmd.CommandText = consul;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conec.conectar;
                cmd.ExecuteNonQuery();
                
                return true;

            } catch {
                return true;
            } finally {
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
                cmd.CommandText = "delete from principalVideo where idVideo = @id";
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
                sql = "select idVideo from principalVideo where url like '" + nombre.ToString() + "'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = dr.GetInt32("idVideo");
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

        public int obtenerIdUsuario(string nombre)
        {
            int id = 0;
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                sql = "select idUsuario from principalVideo where url = '" + nombre.ToString() + "'";
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


    }
}
