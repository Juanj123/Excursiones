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
    public partial class RegistroClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            PojoUsuarios pojousu = new PojoUsuarios();
            DatosRegistroClientes drc = new DatosRegistroClientes();

            pojousu.Nombres = TxtNombre.Text;
            pojousu.Apellidos = Textapellidos.Text;
            pojousu.Telefono = TxtTelefono.Text;
            pojousu.Edad = Convert.ToInt32(Txtedad.Text);
            pojousu.Correo = Textcorreo.Text;
            pojousu.Direccion = Txtdireccion.Text;
            pojousu.Usuario = Txtusuario.Text;
            pojousu.Contraseña = Txtcontrasena.Text;
            pojousu.Tipo = "cliente";

            drc.AgregarClientes(pojousu);
            Response.Redirect("~/login.aspx");
        }
    }
}