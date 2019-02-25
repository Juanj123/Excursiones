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
    public partial class AgregarImagen : System.Web.UI.Page
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
        public static bool insertarImagen(string titulo, string url, string descripcion,string estado)
        {

            DaoImagen daoImagen = new DaoImagen();
            PojoImagen pojoImagen = new PojoImagen()
            {
                IdGaleria = daoImagen.obtenerID(titulo),
                Titulo = titulo,
                Descripcion = descripcion,
                Url = url,
                Estado = estado
                

            };
            bool ok = daoImagen.insertar(pojoImagen);
            return ok;
        }
    }
}