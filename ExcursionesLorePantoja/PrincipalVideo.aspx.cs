using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Pojos;
using Capa_Datos;
using System.Web.Services;

namespace ExcursionesLorePantoja
{
    public partial class PrincipalVideo : System.Web.UI.Page
    {
        private DaoVideo daoVideo;
        private PojoVideo PojoVideo;
        protected void Page_Load(object sender, EventArgs e)
        {
            daoVideo = new DaoVideo();
            PojoVideo = new PojoVideo();
            mostrarVideo();
            //mostrarTabla();
        }

        public void mostrarVideo()
        {
            

            List<PojoVideo> listPojo = new List<PojoVideo>();
            listPojo = daoVideo.obtenerVideo();
            for (int i = 0; i < listPojo.Count(); i++)
            {
                if (listPojo[i].Estado.Equals("Activo"))
                {
                    ltVideo.Text = "<iframe class='d - block w - 100 col-12' width='800' height='400' src='" + listPojo[i].Url + "' frameborder='0' allow='accelerometer; autoplay; encrypted - media; gyroscope; picture -in-picture' allowfullscreen></iframe>";
                    //ltVideo.Text = "<iframe class='d - block w - 100' width='800' height='400' src='https://youtu.be/DkeiKbqa02g?list=RDGzU8KqOY8YA' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen class='col-12'></iframe>";

                    i = listPojo.Count();
                }
            }
            
        }

        public void mostrarTabla()
        {
            var videos = daoVideo.obtenerVideo();
        }

        protected void btnAgregarVideo_Click(object sender, EventArgs e)
        {
            Response.Redirect("agregarVideo.aspx");
        }

        [WebMethod]
        public static List<pojoMostrarVideo> ListVideos()
        {
            List<pojoMostrarVideo> lista= null;
            DaoVideo daoVideo = new DaoVideo();
            try
            {
                lista = daoVideo.obtenerVideos();

            } catch(Exception ex)
            {
                lista = null;
            }
            return lista;
        }

        [WebMethod]
        public static bool ActualizarVideo(string nombre, string url, string estado)
        {

            DaoVideo daoVideo = new DaoVideo();
            PojoVideo pojoVideo = new PojoVideo()
            {
                IdVideo = daoVideo.obtenerID(url),
                IdUsuario = daoVideo.obtenerIdUsuario(url),
                Nombre = nombre,
                Estado = estado,
                Url = url
                
            };
            bool ok = daoVideo.modificar(pojoVideo);
            return ok;
        }

        [WebMethod]
        public static bool EliminarDatos(string id)
        {
            DaoVideo daoVideo = new DaoVideo();
            int idVideo = Convert.ToInt32(daoVideo.obtenerID(id));
            bool ok = daoVideo.Eliminar(idVideo);
            return ok;
        }
    }
}