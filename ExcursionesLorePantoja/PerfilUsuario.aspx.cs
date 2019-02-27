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
    public partial class PerfilUsuario : System.Web.UI.Page
    {
        DatosRegistroClientes datosRegistroClientes = new DatosRegistroClientes();
        List<PojoUsuarios> pojos = new List<PojoUsuarios>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                pojos = datosRegistroClientes.obtenerdatosclientes(Session["login"].ToString());

                for (int i = 0; i < pojos.Count; i++)
                {
                    TxtNombre.Text = pojos[i].Nombres;
                    Textapellidos.Text = pojos[i].Apellidos;
                    TxtTelefono.Text = pojos[i].Telefono;
                    Txtedad.Text = Convert.ToString(pojos[i].Edad);
                    Textcorreo.Text = pojos[i].Correo;
                    Txtdireccion.Text = pojos[i].Direccion;
                    Txtusuario.Text = pojos[i].Usuario;
                    Txtcontrasena.Text = pojos[i].Contraseña;
                }
            }
            
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            PojoUsuarios usuario = new PojoUsuarios();
            DatosRegistroClientes datos = new DatosRegistroClientes();
            usuario.Id = datos.getidusuario(Session["login"].ToString());
            usuario.Nombres = TxtNombre.Text;
            usuario.Apellidos = Textapellidos.Text;
            usuario.Telefono = TxtTelefono.Text;
            usuario.Edad =Convert.ToInt32(Txtedad.Text);
            usuario.Correo = Textcorreo.Text;
            usuario.Direccion = Txtdireccion.Text;
            usuario.Usuario = Txtusuario.Text;
            usuario.Contraseña = Txtcontrasena.Text;
            datos.modificar(usuario);

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('Usuario Modificado');", true);

            pojos = datosRegistroClientes.obtenerdatosclientes(Session["login"].ToString());

            for (int i = 0; i < pojos.Count; i++)
            {
                TxtNombre.Text = pojos[i].Nombres;
                Textapellidos.Text = pojos[i].Apellidos;
                TxtTelefono.Text = pojos[i].Telefono;
                Txtedad.Text = Convert.ToString(pojos[i].Edad);
                Textcorreo.Text = pojos[i].Correo;
                Txtdireccion.Text = pojos[i].Direccion;
                Txtusuario.Text = pojos[i].Usuario;
                Txtcontrasena.Text = pojos[i].Contraseña;
            }
        }
    }
}