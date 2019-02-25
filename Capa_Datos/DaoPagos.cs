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
    public class DaoPagos
    {
        cone cone = new cone();

        public List<PojoPagos> obtenerPagos()
        {

            //try
            //{

            List<PojoPagos> concep = new List<PojoPagos>();
            PojoPagos pojoAmbu;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            cone.conexion();
            string sql = " select * from pagos";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cone.conectar;
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                pojoAmbu = new PojoPagos();
                pojoAmbu.IdPagos = dr.GetInt32("destino");
                pojoAmbu.IdReservacion = dr.GetInt32("hora_salida");
                pojoAmbu.IdUsuario = dr.GetInt32("dia");
                pojoAmbu.Monto = dr.GetDouble("mes");
                //pojoAmbu.Año = dr.GetInt32("año");
                pojoAmbu.Fecha_pago = dr.GetString("costo_adulto");
                pojoAmbu.Estado = dr.GetString("descripcion");
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
            cone.conectar.Close();
            //}
        }
    }
}
