using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Capa_Datos
{
    public class DatosLogin
    {
        cone cone = new cone();
        public MySqlDataReader autenticar(string nombre, string contrasena)
        {
            try
            {
                string mysql = "select * from usuarios where usuario='" + nombre + "'and contraseña='" + contrasena + "'";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                cone.conexion();
                cm.CommandText = mysql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cone.conectar;
                dr = cm.ExecuteReader();
                return dr;
            }
            catch
            {
                return null;
            }
            finally
            {
                //cone
            }
        }
    }
}
