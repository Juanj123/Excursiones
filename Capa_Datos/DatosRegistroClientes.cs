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

        public List<PojoUsuarios> obtenerdatosclientes(string usuario)
        {

            

                List<PojoUsuarios> concep = new List<PojoUsuarios>();
                PojoUsuarios pojoAmbu;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                cone.conexion();
                string sql = "select *from usuarios where Usuario='"+usuario+"'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = cone.conectar;
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    pojoAmbu = new PojoUsuarios();
                    pojoAmbu.Nombres = dr.GetString("nombres");
                    pojoAmbu.Apellidos = dr.GetString("apellidos");
                    pojoAmbu.Telefono = dr.GetString("telefono");
                    pojoAmbu.Edad = dr.GetInt32("edad");
                    pojoAmbu.Correo = dr.GetString("correo");
                    pojoAmbu.Direccion = dr.GetString("direccion");
                    pojoAmbu.Usuario = dr.GetString("Usuario");
                    //pojoAmbu.Contraseña = dr.GetString("contraseña");
                    pojoAmbu.Tipo = dr.GetString("tipo");
                    concep.Add(pojoAmbu);
                }
            cone.conectar.Close();
            return concep;
        }

        public bool modificar(PojoUsuarios usu)
        {
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cone.conexion();
                cmd.Parameters.AddWithValue("@idUsuario", usu.Id);
                cmd.Parameters.AddWithValue("@nombres", usu.Nombres);
                cmd.Parameters.AddWithValue("@apellidos", usu.Apellidos);
                cmd.Parameters.AddWithValue("@telefono", usu.Telefono);
                cmd.Parameters.AddWithValue("@edad", usu.Edad);
                cmd.Parameters.AddWithValue("@correo", usu.Correo);
                cmd.Parameters.AddWithValue("@direccion", usu.Direccion);
                cmd.Parameters.AddWithValue("@Usuario", usu.Usuario);
                cmd.Parameters.AddWithValue("@contraseña", usu.Contraseña);
                string consul = "update usuarios set  idUsuario=@idUsuario, nombres=@nombres, apellidos=@apellidos, telefono=@telefono, edad=@edad, correo=@correo, direccion=@direccion, Usuario=@Usuario, contraseña=@contraseña where idUsuario=@idUsuario";
                cmd.CommandText = consul;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.conectar;
                cmd.ExecuteNonQuery();

                return true;

            }
            catch
            {
                return true;
            }
            finally
            {
                cone.conectar.Close();
                cone.conectar.Close();
            }

        }

        public int getidusuario(string id)
        {

            int idAutobus = 0;
            cone.conexion();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            sql = "select idUsuario from usuarios where Usuario= '" + id + "';";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cone.conectar;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idAutobus = dr.GetInt32("idUsuario");
            }
            cone.conectar.Close();
            return idAutobus;
        }
    }
}
