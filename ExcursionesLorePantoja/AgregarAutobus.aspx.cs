using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Pojos;

namespace ExcursionesLorePantoja
{
    public partial class AgregarAutobus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            PojoAutobus pojoAutobus = new PojoAutobus();
            DaoAutobus daoAutobus = new DaoAutobus();

            pojoAutobus.Nombre = dpdlNombre.SelectedItem.Text;
            pojoAutobus.NAsientos = Convert.ToInt32(txtAsientos.Text);

            if (daoAutobus.insertar(pojoAutobus))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Autobus Guardado');", true);
                Response.Redirect("Autobus.aspx");
            }

        }
    }
}