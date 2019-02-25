using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Pojos;

namespace ExcursionesLorePantoja
{
    public partial class Autobus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarAutobus_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarAutobus.aspx");
        }

        [WebMethod]
        public static List<PojoAutobus> ListAutobus()
        {
            List<PojoAutobus> lista = null;
            DaoAutobus daoAutobus = new DaoAutobus();
            try
            {
                lista = daoAutobus.obtenerAutobus();

            }
            catch (Exception ex)
            {
                lista = null;
            }
            return lista;
        }

        [WebMethod]
        public static bool EliminarDatos(string id)
        {
            DaoAutobus daoAutobus = new DaoAutobus();
            int idVideo = Convert.ToInt32(id);
            bool ok = daoAutobus.Eliminar(idVideo);
            return ok;
        }
    }
}