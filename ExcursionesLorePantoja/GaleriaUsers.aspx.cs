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
    public partial class GaleriaUsers : System.Web.UI.Page
    {
        DatosGaleriaUsers galeriaUsers = new DatosGaleriaUsers();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                cardarDatos();
                List<PojoGaleria> ltAutobus = new List<PojoGaleria>();
                ltAutobus = galeriaUsers.obtenerrutas(combodestinos.SelectedItem.Text);

                for (int i = 0; i < ltAutobus.Count; i++)
                {
                    ltimagenesgaleria.Text +="<div class='col-md-4'><div class='card'><a class='lightbox' href='" + ltAutobus[i].Img_galeria + "'><img src = '" + ltAutobus[i].Img_galeria + "' alt='Park' class='card-img-top'></a></div></div>";
                }
            }
        }

        public void cardarDatos()
        {

            List<PojoGaleria> ltAutobus = new List<PojoGaleria>();

            ltAutobus = galeriaUsers.obtenerAutobus();

            for (int i = 0; i < ltAutobus.Count(); i++)
            {
                combodestinos.Items.Add(ltAutobus[i].Destino);
            }

        }

        protected void combodestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PojoGaleria> ltAutobus = new List<PojoGaleria>();
            ltAutobus= galeriaUsers.obtenerrutas(combodestinos.SelectedItem.Text);

            for (int i = 0; i < ltAutobus.Count; i++)
            {
                ltimagenesgaleria.Text += "<div class='col - md - 4'>< div class='card'><a class='lightbox' href='"+ltAutobus[i].Img_galeria+ "'><img src = '" + ltAutobus[i].Img_galeria + "' alt='Park' class='card-img-top'></a></div></div>";
            }
        }
    }
}