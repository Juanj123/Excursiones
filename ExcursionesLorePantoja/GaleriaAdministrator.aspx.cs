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
    public partial class PrincipalGaleria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<pojoMostrarGaleria> ListGaleria()
        {
            List<pojoMostrarGaleria> lista = null;
            DaoGaleria daoGaleria = new DaoGaleria();
            try
            {
                lista = daoGaleria.obtenerGaleria();

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
            DaoGaleria daoGaleria = new DaoGaleria();
            int idVideo = Convert.ToInt32(daoGaleria.obtenerID(id));
            bool ok = daoGaleria.Eliminar(idVideo);
            return ok;
        }

        protected void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            Response.Redirect("agregarGaleria.aspx");
        }
    }
}