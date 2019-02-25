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
    public class DaoGaleria
    {

        cone conec = new cone();

        public string insertar(PojoGaleria pojoGaleria)
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conexion();
            cmd.Parameters.AddWithValue("@idGaleria", pojoGaleria.IdGaleria);
            cmd.Parameters.AddWithValue("@idUsuario", pojoGaleria.IdUsuario);
            cmd.Parameters.AddWithValue("@titulo", pojoGaleria.Titulo);
            cmd.Parameters.AddWithValue("@img_galeria", pojoGaleria.Img_galeria);
            string consul = "insert into galeria(idGaleria, idUsuario, titulo,img_galeria)VALUES(null,@idUsuario,@titulo,@img_galeria)";
            cmd.CommandText = consul;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conec.conectar;
            cmd.ExecuteNonQuery();
            conec.conectar.Close();
            return "Guardado";

        }

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

        public bool Eliminar(int id)
        {
            try
            {
                conec.conexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conec.conectar;
                cmd.Parameters.AddWithValue("@id", id.ToString());
                cmd.CommandText = "delete from galeria where idGaleria = @id";
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

    }
}
