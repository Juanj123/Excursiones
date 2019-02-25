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
    public class DaoPrincipalGaleria
    {
        cone conec = new cone();

        public List<pojoMostrarGaleria> obtenerGaleria()
        {

            try
            {

                List<pojoMostrarGaleria> concep = new List<pojoMostrarGaleria>();
                pojoMostrarGaleria pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                string sql = "select titulo, img_galeria from galeria";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new pojoMostrarGaleria();
                    pojoAmbu.Titulo = dr.GetString("titulo");
                    pojoAmbu.Img_galeria = dr.GetString("img_galeria");
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

        public List<PojoPrincipalGaleria> obtenerImagenes()
        {

            try
            {

                List<PojoPrincipalGaleria> concep = new List<PojoPrincipalGaleria>();
                PojoPrincipalGaleria pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                string sql = "select idGaleria, img from principalGaleria";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoPrincipalGaleria();
                    pojoAmbu.IdGaleria = dr.GetInt32("idGaleria");
                    pojoAmbu.Img = dr.GetString("img");
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

        public List<PojoPrincipalGaleria> MostrarImagenes()
        {

            try
            {

                List<PojoPrincipalGaleria> concep = new List<PojoPrincipalGaleria>();
                PojoPrincipalGaleria pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                string sql = "select img from principalGaleria";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoPrincipalGaleria();
                    pojoAmbu.Img = dr.GetString("img");
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

        public bool insertar(PojoPrincipalGaleria pojoPrincipalGaleria)
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conexion();
            cmd.Parameters.AddWithValue("@idGaleria", pojoPrincipalGaleria.IdGaleria);
            cmd.Parameters.AddWithValue("@img", pojoPrincipalGaleria.Img);
            string consul = "insert into principalGaleria(idGaleria, img)VALUES(@idGaleria, @img)";
            cmd.CommandText = consul;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conec.conectar;
            cmd.ExecuteNonQuery();
            conec.conectar.Close();
            return true;

        }

        public bool Eliminar(int id)
        {
            try
            {
                conec.conexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conec.conectar;
                cmd.Parameters.AddWithValue("@id", id.ToString());
                cmd.CommandText = "delete from principalGaleria where idGaleria = @id";
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

        public bool modificar(PojoPrincipalGaleria Alma)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conec.conexion();

                cmd.Parameters.AddWithValue("@idGaleria", Alma.IdGaleria);
                cmd.Parameters.AddWithValue("@Img", Alma.Img);

                string consul = "update principalGaleria set  idGaleria=@idGaleria, img=@Img where idGaleria=@idGaleria";
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

        public List<PojoPrincipal> obtenerIdPrincipal()
        {

            try
            {

                List<PojoPrincipal> concep = new List<PojoPrincipal>();
                PojoPrincipal pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                string sql = " select idPrincipal from principal";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoPrincipal();
                    pojoAmbu.IdPrincipal = dr.GetInt32("idPrincipal");
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

        public bool obtenerIdGaleria(string url)
        {
            bool id = false;
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                sql = "select idGaleria  from galeria where img_galeria like '" + url.ToString() + "'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = true;
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
