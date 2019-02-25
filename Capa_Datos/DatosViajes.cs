using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Pojos;
using MySql.Data.MySqlClient;
using System.Data;

namespace Capa_Datos
{
    public class DatosViajes
    {
        cone cone = new cone();
        public List<PojoViajes> obtenerViajes()
        {



            List<PojoViajes> concep = new List<PojoViajes>();
            PojoViajes pojoAmbu;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            cone.conexion();
            string sql = " select * from viajes";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cone.conectar;
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                pojoAmbu = new PojoViajes();
                pojoAmbu.Idviaje = dr.GetInt32("idviaje");
                //pojoAmbu.Idautobus = dr.GetInt32("idautobus");
                pojoAmbu.Destino = dr.GetString("destino");
                pojoAmbu.Horaregreso = dr.GetString("hora_regreso");
                pojoAmbu.Horasalida = dr.GetString("hora_salida");
                pojoAmbu.Costoadulto = dr.GetDouble("costo_adulto");
                //pojoAmbu.Costonino = dr.GetDouble("costo_niño");
                pojoAmbu.Descripcion = dr.GetString("descripcion");
                //pojoAmbu.Fecha = dr.GetString("fecha");
                pojoAmbu.Nota = dr.GetString("nota");
                //pojoAmbu.Img =(byte[])dr["img"];
                concep.Add(pojoAmbu);
            }
            return concep;
        }

        public List<PojoViajes> getDatosProductobynombre(string clave)
        {
            List<PojoViajes> lstviaje = new List<PojoViajes>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            cone.conexion();
            sql = "SELECT  * from viajes where destino like '" + clave + "%'";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cone.conectar;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                PojoViajes pojoAmbu = new PojoViajes();
                pojoAmbu.Idviaje = dr.GetInt32("idviaje");
                pojoAmbu.Idautobus = dr.GetInt32("idautobus");
                pojoAmbu.Destino = dr.GetString("destino");
                pojoAmbu.Horaregreso = dr.GetString("hora_regreso");
                pojoAmbu.Horasalida = dr.GetString("hora_salida");
                pojoAmbu.Costoadulto = dr.GetDouble("costo_adulto");
                //pojoAmbu.Costonino = dr.GetDouble("costo_niño");
                pojoAmbu.Descripcion = dr.GetString("descripcion");
                //pojoAmbu.Fecha = dr.GetString("fecha");
                pojoAmbu.Nota = dr.GetString("nota");
                //pojoAmbu.Img =(byte[])dr["img"];
                lstviaje.Add(pojoAmbu);
            }


            return lstviaje;
        }
    }
}
