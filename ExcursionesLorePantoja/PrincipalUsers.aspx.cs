using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Pojos;
using System.Text;

namespace ExcursionesLorePantoja
{
    public partial class PrincipalUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarParrafo();
            mostrarImagenes();
        }

        public void mostrarParrafo()
        {
            List<PojoPrincipal> lista = new List<PojoPrincipal>();
            DaoPrincipal daoPrincipal = new DaoPrincipal();
            lista = daoPrincipal.obtenerDescripcion();

            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].Estado.Equals("Activo"))
                {
                    ltParrafo.Text = "<p class='text-justify e'>" + lista[i].Descripcion + "</p>";
                    i = lista.Count();
                }
            }

        }


        public void mostrarImagenes()
        {
            if (!Page.IsPostBack)
            {
                ObjectCache cache = MemoryCache.Default;
                if (cache["CarouselInnerHtml"] != null)
                {
                    //use the cached html
                    ltImg.Text = cache["CarouselInnerHtml"].ToString();

                }
                else
                {
                    List<PojoPrincipalGaleria> lista = new List<PojoPrincipalGaleria>();
                    DaoPrincipalGaleria daoPrincipal = new DaoPrincipalGaleria();
                    var carouselInnerHtml = new StringBuilder();


                    lista = daoPrincipal.MostrarImagenes();


                    for (int i = 0; i < lista.Count(); i++)
                    {

                        if (i == 0)
                        {
                            carouselInnerHtml.AppendLine("<div class='carousel-item active'>");
                            carouselInnerHtml.AppendLine("<img src='" + lista[i].Img + "' alt='Third slide' style='width: 100%; height: 100%;' />");
                            carouselInnerHtml.AppendLine("</div>");
                        }
                        else
                        {
                            carouselInnerHtml.AppendLine("<div class='carousel-item'>");
                            carouselInnerHtml.AppendLine("<img src='" + lista[i].Img + "' alt='Second slide' style='width: 100%; height: 100%;' />");
                            carouselInnerHtml.AppendLine("</div>");
                        }


                       
                    }
                    cache["CarouselInnerHtml"] = ltImg.Text = carouselInnerHtml.ToString();
                }
            }

        }
    }
}