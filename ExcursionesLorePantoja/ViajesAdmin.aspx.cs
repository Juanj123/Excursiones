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
    public partial class ViajesAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarViaje.aspx");
        }

        [WebMethod]
        public static List<PojoViaje> ListViajes()
        {
            List<PojoViaje> lista = null;
            DaoViaje daoViaje = new DaoViaje();
            try
            {
                lista = daoViaje.obtenerViajes();

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
            DaoViaje daoViaje = new DaoViaje();
            int idVideo = Convert.ToInt32(daoViaje.obtenerID(id));
            bool ok = daoViaje.Eliminar(idVideo);
            return ok;
        }
    }
}