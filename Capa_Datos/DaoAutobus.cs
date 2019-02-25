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
    public class DaoAutobus
    {
        cone conec = new cone();
        public bool insertar(PojoAutobus pojoAutobus)
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conexion();
            cmd.Parameters.AddWithValue("@idAutobus", pojoAutobus.IdAutobus);
            cmd.Parameters.AddWithValue("@nombre", pojoAutobus.Nombre);
            cmd.Parameters.AddWithValue("@nAsientos", pojoAutobus.NAsientos);
            
            string consul = "insert into autobus(idAutobus, nombre, img, n_Asientos)VALUES(null,@nombre,null,@nAsientos)";
            cmd.CommandText = consul;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conec.conectar;
            cmd.ExecuteNonQuery();
            conec.conectar.Close();
            return true;

        }

        public List<PojoAutobus> obtenerAutobus()
        {

            try
            {

                List<PojoAutobus> concep = new List<PojoAutobus>();
                PojoAutobus pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                string sql = " select idAutobus, nombre, n_Asientos from autobus";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoAutobus();
                    pojoAmbu.IdAutobus = dr.GetInt32("idAutobus");
                    pojoAmbu.Nombre = dr.GetString("nombre");
                    pojoAmbu.NAsientos = dr.GetInt32("n_Asientos");
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

        public bool modificar(PojoAutobus pojoAutobus)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conec.conexion();

                cmd.Parameters.AddWithValue("@idAutobus", pojoAutobus.IdAutobus);
                cmd.Parameters.AddWithValue("@nombre", pojoAutobus.Nombre);
                cmd.Parameters.AddWithValue("@nAsientos", pojoAutobus.NAsientos);

                string consul = "update autobus set  nombre=@nombre, img=null, n_Asientos=@nAsientos where idAutobus=@idAutobus";
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
                cmd.CommandText = "delete from autobus where idAutobus = @id";
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
                sql = "select idAutobus from autobus where nombre like '" + nombre.ToString() + "'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = dr.GetInt32("idAutobus");
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
