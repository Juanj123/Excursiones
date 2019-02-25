using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Runtime.Caching;
using System.Web.Caching;
using System.IO;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Pojos;

namespace ExcursionesLorePantoja
{
    public partial class PrincipalGaleria1 : System.Web.UI.Page
    {
        DaoPrincipal daoPrincipal = new DaoPrincipal();
        PojoPrincipal pojoPrincipal = new PojoPrincipal();

        DaoPrincipalGaleria daoPrincipalGaleria = new DaoPrincipalGaleria();
        PojoPrincipalGaleria pojoPrincipalGaleria = new PojoPrincipalGaleria();
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
                    ltParrafo.Text = "<p class='text-justify e'>"+lista[i].Descripcion+"</p>";
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
                            carouselInnerHtml.AppendLine("<img src='" + lista[i].Img + "' alt='Third slide' />");
                            carouselInnerHtml.AppendLine("</div>");
                        }
                        else
                        {
                            carouselInnerHtml.AppendLine("<div class='carousel-item'>");
                            carouselInnerHtml.AppendLine("<img src='" + lista[i].Img + "' alt='Second slide' />");
                            carouselInnerHtml.AppendLine("</div>");
                        }
                        

                        //ltParrafo.Text = "<div class='carousel-item active'>  <img class='d-block w-100' src='"+ lista[1].Img + "' alt='Third Slide'/> </div>";
                        //ltParrafo.Text = "<div class='carousel-item'>  <img class='d-block w-100' src='" + lista[i].Img + "' alt='Second Slide'/> </div>";
                    }
                    cache["CarouselInnerHtml"] = ltImg.Text = carouselInnerHtml.ToString();
                }
            }
           
        }

        [WebMethod]
        public static List<PojoPrincipal> cardarDatos()
        {
            DaoPrincipalGaleria daoPrincipalGaleria = new DaoPrincipalGaleria();
            List<PojoPrincipal> ltPrincipal = new List<PojoPrincipal>();

            try
            {
                ltPrincipal = daoPrincipalGaleria.obtenerIdPrincipal();
            }
            catch (Exception ex)
            {
                ltPrincipal = null;
            }

            return ltPrincipal;
            //for (int i = 0; i < ltPrincipal.Count(); i++)
            //{
            //    dpdlIdDescripcion.Items.Add(Convert.ToString(ltPrincipal[i].IdPrincipal));
            //}

        }

        //public void cardarDatos()
        //{

        //    List<PojoPrincipal> ltPrincipal = new List<PojoPrincipal>();

        //    ltPrincipal = daoPrincipalGaleria.obtenerIdPrincipal();

        //    for (int i = 0; i < ltPrincipal.Count(); i++)
        //    {
        //        dpdlIdDescripcion.Items.Add(Convert.ToString(ltPrincipal[i].IdPrincipal));
        //    }

        //}

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //pojoPrincipal.Descripcion = txtDescripcion.Text;
            //if (daoPrincipal.insertar(pojoPrincipal).Equals("Guardado"))
            //{
            //    txtDescripcion.Text = null;
            //}
        }

        protected void btnAgregarImg_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarPrincipalGaleria.aspx");
        }

        protected void btnDescripcion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Descripcion.aspx");

        }
        [WebMethod]
        public static List<PojoPrincipalGaleria> ListImg()
        {

            List<PojoPrincipalGaleria> lista = null;
            DaoPrincipalGaleria daoPrincipalGaleria = new DaoPrincipalGaleria();
            try
            {
                lista = daoPrincipalGaleria.obtenerImagenes();

            }
            catch (Exception ex)
            {
                lista = null;
            }
            return lista;
        }

        [WebMethod]
        public static List<pojoMostrarGaleria> comboDescri()
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
        public static bool Actualizar(string titulo, string url, string descripcion)
        {

            DaoPrincipalGaleria daoPrincipalGaleria = new DaoPrincipalGaleria();
            PojoPrincipalGaleria pojoPrincipalGaleria = new PojoPrincipalGaleria()
            {
                IdGaleria = Convert.ToInt32(titulo),
                Img = url

            };
            bool ok = daoPrincipalGaleria.modificar(pojoPrincipalGaleria);
            return ok;
        }

        [WebMethod]
        public static bool EliminarDatos(string id)
        {
            DaoPrincipalGaleria daoPrincipalGaleria = new DaoPrincipalGaleria();
            int idPrincipalGaleria = Convert.ToInt32(id);
            bool ok = daoPrincipalGaleria.Eliminar(idPrincipalGaleria);
            return ok;
        }


    }
}