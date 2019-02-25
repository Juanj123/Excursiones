using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using MySql.Data.MySqlClient;

namespace ExcursionesLorePantoja
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void entrar_Click(object sender, EventArgs e)
        {
            DatosLogin datos = new DatosLogin();

            string usuario = txtnombreusuario.Text;
            string contraena = txtcontrasena.Text;

            if (datos.autenticar(usuario, contraena).Read() == true)
            {
                Session["login"] = txtnombreusuario.Text;
                Response.Redirect("PrincipalUsers.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Datos Incorrectod');", true);
            }
        }
    }
}