using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Pojos;
using Capa_Datos;
using System.Web.Services;

namespace ExcursionesLorePantoja
{
    public partial class Imagen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarImg_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarImagen.aspx");
        }

        [WebMethod]
        public static List<PojoImagen> ListImagen()
        {
            List<PojoImagen> lista = null;
            DaoImagen daoImagen = new DaoImagen();
            try
            {
                lista = daoImagen.obtenerImagen();

            }
            catch (Exception ex)
            {
                lista = null;
            }
            return lista;
        }

        [WebMethod]
        public static bool ActualizarImagen(string titulo, string url, string descripcion, string estado)
        {

            DaoImagen daoImagen = new DaoImagen();
            PojoImagen pojoImagen = new PojoImagen()
            {
                IdImagen = daoImagen.obtenerIDImagen(titulo),
                IdGaleria = daoImagen.obtenerID(titulo),
                Titulo = titulo,
                Descripcion = descripcion,
                Url = url,
                Estado = estado


            };
            bool ok = daoImagen.modificar(pojoImagen);
            return ok;
        }

        [WebMethod]
        public static bool EliminarDatos(string id)
        {
            DaoImagen daoImagen = new DaoImagen();
            int idVideo = Convert.ToInt32(daoImagen.obtenerIDImagen(id));
            bool ok = daoImagen.Eliminar(idVideo);
            return ok;
        }
    }
}