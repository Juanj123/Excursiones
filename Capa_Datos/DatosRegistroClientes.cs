using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Capa_Pojos;
using System.Data;

namespace Capa_Datos
{
    public class DatosRegistroClientes
    {
        cone cone = new cone();
        public void AgregarClientes(PojoUsuarios objclientes)
        {
            string sql;
            MySqlCommand cm;
            cone.conexion();
            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@nombres", objclientes.Nombres);
            cm.Parameters.AddWithValue("@apellidos", objclientes.Apellidos);
            cm.Parameters.AddWithValue("@telefono", objclientes.Telefono);
            cm.Parameters.AddWithValue("@edad", objclientes.Edad);
            cm.Parameters.AddWithValue("@correo", objclientes.Correo);
            cm.Parameters.AddWithValue("@direccion", objclientes.Direccion);
            cm.Parameters.AddWithValue("@Usuario", objclientes.Usuario);
            cm.Parameters.AddWithValue("@contraseña", objclientes.Contraseña);
            cm.Parameters.AddWithValue("@tipo", objclientes.Tipo);
            sql = "INSERT INTO usuarios(idUsuario,nombres,apellidos, telefono, edad, correo, direccion, Usuario, contraseña,tipo) VALUES (null,@nombres, @apellidos, @telefono, @edad, @correo, @direccion, @Usuario, @contraseña, @tipo)";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cone.conectar;
            cm.ExecuteNonQuery();
            cone.conectar.Close();
        }

        public List<PojoUsuarios> obtenerClientes()
        {

            try
            {

                List<PojoUsuarios> concep = new List<PojoUsuarios>();
                PojoUsuarios pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                cone.conexion();
                string sql = "select nombres, apellidos, correo, Usuario from usuarios";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cone.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoUsuarios();
                    pojoAmbu.Nombres = dr.GetString("nombres");
                    pojoAmbu.Apellidos = dr.GetString("apellidos");
                    pojoAmbu.Correo = dr.GetString("correo");
                    pojoAmbu.Usuario = dr.GetString("Usuario");
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
    }
}
