using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Web;
using System.Data;

namespace Capa_Datos
{
    class cone
    {
        public MySqlConnection conectar = new MySqlConnection();
        public void conexion()
        {
            try
            {
                conectar.ConnectionString = "SERVER=" + Configuracion.G_SERVER + ";port=" + Configuracion.G_PUERTO + ";Database=" + Configuracion.G_DATABASE + ";UID=" + Configuracion.G_USER_ID + ";password=" + Configuracion.G_USER_PWD + ";pooling=false";
                conectar.Open();
            }
            catch (Exception ExceptionErr)
            {
                throw new System.Exception(ExceptionErr.Message, ExceptionErr.InnerException);
            }
        }
    }
}
