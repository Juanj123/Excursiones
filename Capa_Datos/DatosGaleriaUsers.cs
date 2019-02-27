using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Capa_Pojos;
using Capa_Datos;

namespace Capa_Datos
{
    public class DatosGaleriaUsers
    {
        cone cone = new cone();

        public List<PojoGaleria> obtenerAutobus()
        {

            try
            {

                List<PojoGaleria> concep = new List<PojoGaleria>();
                PojoGaleria pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                cone.conexion();
                string sql = " select destino from galeria";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cone.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoGaleria();
                    pojoAmbu.Destino = dr.GetString("destino");
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
                cone.conectar.Close();
            }
        }

        public List<PojoGaleria> obtenerrutas(string clave)
        {

            //try
            //{

                List<PojoGaleria> concep = new List<PojoGaleria>();
                PojoGaleria pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                cone.conexion();
                string sql = " select img_galeria from galeria where destino='" + clave + "'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cone.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoGaleria();
                    pojoAmbu.Img_galeria = dr.GetString("img_galeria");
                    concep.Add(pojoAmbu);
                }
                return concep;
            //}
            //catch (Exception exc)
            //{
            //    return null;
            //}
            //finally
            //{
                cone.conectar.Close();
            //}
        }
    }
}
