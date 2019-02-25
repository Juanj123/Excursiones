using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Pojos;
using Capa_Datos;

namespace ExcursionesLorePantoja
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<PojoUsuarios> List()
        {
            List<PojoUsuarios> lista = null;
            DatosRegistroClientes datosRegistroClientes = new DatosRegistroClientes();
            try
            {
                lista = datosRegistroClientes.obtenerClientes();

            }
            catch (Exception ex)
            {
                lista = null;
            }
            return lista;
        }
    }
}