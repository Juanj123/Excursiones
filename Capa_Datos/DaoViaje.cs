using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Pojos;
using MySql.Data.MySqlClient;
using MySql.Web;
using System.Data;
using System.IO;

namespace Capa_Datos
{
    public class DaoViaje
    {
        cone conec = new cone();
        public string insertar(PojoViaje pojoViaje)
        {
            MySqlCommand cmd = new MySqlCommand();
            conec.conexion();
            cmd.Parameters.AddWithValue("@idAutobus", pojoViaje.IdAutobus);
            cmd.Parameters.AddWithValue("@img", pojoViaje.Img);
            cmd.Parameters.AddWithValue("@destino", pojoViaje.Destino);
            cmd.Parameters.AddWithValue("@hora", pojoViaje.Hora);
            cmd.Parameters.AddWithValue("@costo", pojoViaje.Costo);
            cmd.Parameters.AddWithValue("@costoNinio", pojoViaje.CostoNinio);
            cmd.Parameters.AddWithValue("@costoAd", pojoViaje.CostoAd);
            cmd.Parameters.AddWithValue("@descripcion", pojoViaje.Descripcion);
            cmd.Parameters.AddWithValue("@dia", pojoViaje.Dia);
            cmd.Parameters.AddWithValue("@mes", pojoViaje.Mes);
            cmd.Parameters.AddWithValue("@año", pojoViaje.Año);
            cmd.Parameters.AddWithValue("@nota", pojoViaje.Nota);
            cmd.Parameters.AddWithValue("@itinerario", pojoViaje.Itinerario);
            string consul = "insert into viajes(idViaje,idAutobus, img, destino, hora_regreso, hora_salida, costo_adulto, costo_niño, costo_ad, descripcion, dia, mes, año, nota, itinerario)VALUES(null, @idAutobus, @img, @destino, null, @hora, @costo, @costoNinio, @costoAd, @descripcion, @dia, @mes, @año, @nota, @itinerario)";
            cmd.CommandText = consul;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conec.conectar;
            cmd.ExecuteNonQuery();
            conec.conectar.Close();
            return "Guardado";

        }

        public bool Eliminar(int id)
        {
            try
            {
                conec.conexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conec.conectar;
                cmd.Parameters.AddWithValue("@id", id.ToString());
                cmd.CommandText = "delete from viajes where idViaje = @id";
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
                sql = "select idViaje from viajes where destino like '" + nombre.ToString() + "'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = dr.GetInt32("idViaje");
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


        public List<PojoViaje> obtenerViajes()
        {

            //try
            //{

                List<PojoViaje> concep = new List<PojoViaje>();
                PojoViaje pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                conec.conexion();
                string sql = " select destino, hora_salida, dia, mes, costo_adulto, descripcion from viajes";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoViaje();
                    pojoAmbu.Destino = dr.GetString("destino");
                    pojoAmbu.Hora = dr.GetString("hora_salida");
                    pojoAmbu.Dia = dr.GetInt32("dia");
                    pojoAmbu.Mes = dr.GetInt32("mes");
                    //pojoAmbu.Año = dr.GetInt32("año");
                    pojoAmbu.Costo = dr.GetDouble("costo_adulto");
                    pojoAmbu.Descripcion = dr.GetString("descripcion");
                    concep.Add(pojoAmbu);
                }
                return concep;
            //}
            //catch (Exception exc)
            //{

                return null;
            //}
            //finally
            //{
                conec.conectar.Close();
            //}
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
                string sql = " select idAutobus from autobus";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conec.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoAutobus();
                    pojoAmbu.IdAutobus = dr.GetInt32("idAutobus");
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
