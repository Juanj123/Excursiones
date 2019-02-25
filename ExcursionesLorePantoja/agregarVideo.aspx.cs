using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Pojos;
using Capa_Datos;

namespace ExcursionesLorePantoja
{
    public partial class agregarVideo : System.Web.UI.Page
    {
        PojoVideo pojoVideo = new PojoVideo();
        DaoVideo daoVideo = new DaoVideo();
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "confirm", "confirm('Algo');", true);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            pojoVideo.IdUsuario = Convert.ToInt32(1);
            pojoVideo.Nombre = txtNombre.Text;
            pojoVideo.Url = txtUrl.Text;
            pojoVideo.Estado = dplActivo.SelectedItem.Text;

            if (daoVideo.insertar(pojoVideo).Equals("Guardado"))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "confirm", "confirm('Video Guardado');", true);
                Response.Redirect("PrincipalVideo.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Video no Guardado');", true);
            }
            
            
         
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PrincipalVideo.aspx");
        }
    }
}