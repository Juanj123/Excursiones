using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Pojos;

namespace ExcursionesLorePantoja
{
    public partial class AgregarViaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cardarDatos();
        }
        PojoViaje pojoViaje = new PojoViaje();
        DaoViaje daoViaje = new DaoViaje();

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //string ruta = "";
            //bool existe;
            //HttpPostedFile pf = FileUpload1.PostedFile;
            ////HttpPostedFile mifichero;
            ////mifichero = FileUpload1.PostedFile;
            //ruta = Server.MapPath("~/img/imgGaleria");
            //existe = Directory.Exists(ruta);


            //if (!existe)
            //{
            //    Directory.CreateDirectory(ruta);
            //}
            try
            {
                string ruta = "";
                string rutaInicial = "";
                bool existe;

                ruta = Server.MapPath("img\\");
                existe = Directory.Exists(ruta);


                if (!existe)
                {
                    Directory.CreateDirectory(ruta);
                }

                if (FileUpload1.HasFile)
                {
                    // se obtiene la extension y el tamaño para delimitar
                    string ext = Path.GetExtension(FileUpload1.FileName);
                    ext = ext.ToLower();

                    int tam = FileUpload1.PostedFile.ContentLength;
                    //Response.Write(ext + " , " + tam);

                    if (ext == ".png" || ext == ".jpg" && tam <= 1048576)
                    {
                        FileUpload1.SaveAs(Server.MapPath("~\\img\\" + FileUpload1.FileName));
                        string path = "img\\" + FileUpload1.FileName;
                        pojoViaje.IdAutobus = Convert.ToInt32(dpdlAutobus.SelectedItem.Text);
                        pojoViaje.Destino = txtDestino.Text;
                        pojoViaje.Descripcion = txtDestino.Text;
                        pojoViaje.Hora = txtHora.Text;
                        pojoViaje.Costo = Convert.ToDouble(txtCosto.Text);
                        pojoViaje.CostoNinio = Convert.ToDouble(txtCostoM.Text);
                        pojoViaje.CostoAd = Convert.ToDouble(txtCostoMen.Text);
                        pojoViaje.Descripcion = txtDescripcion.Text;
                        pojoViaje.Dia = Convert.ToInt32(txtDia.Text);
                        pojoViaje.Mes = Convert.ToInt32(txtMes.Text);
                        pojoViaje.Año = Convert.ToInt32(txtAnio.Text);
                        pojoViaje.Nota = txtNota.Text;
                        pojoViaje.Itinerario = txtItinerario.Text;
                        pojoViaje.Img = path;

                        daoViaje.insertar(pojoViaje);

                        Response.Redirect("ViajesAdmin.aspx");
                    }
                }
            }
            catch (Exception ex)
            { }
           
            //HttpPostedFile mifichero;
            //mifichero = FileUpload1.PostedFile;
           
          

                    //if (FileUpload1.HasFile)
                    //{
                    //    // se obtiene la extension y el tamaño para delimitar
                    //    string ext = Path.GetExtension(FileUpload1.FileName);
                    //    ext = ext.ToLower();

                    //    int tam = pf.ContentLength;
                    //    //Response.Write(ext + " , " + tam);
                    //    //&& tam <= 1048576
                    //    if (ext == ".png" || ext == ".jpg" && tam <= 1048576)
                    //    {

                    //FileUpload1.SaveAs(Server.MapPath("~/img/imgGaleria/" + FileUpload1.FileName));
                    //string path = Server.MapPath("~/img/imgGaleria/" + FileUpload1.FileName);

                    //Stream stream = pf.InputStream;
                    //BinaryReader br = new BinaryReader(stream);
                    //byte[] img = br.ReadBytes((int)stream.Length);

                   
            
        }

        public void cardarDatos()
        {
            
            List<PojoAutobus> ltAutobus = new List<PojoAutobus>();

            ltAutobus = daoViaje.obtenerAutobus();

            for (int i = 0; i < ltAutobus.Count(); i++)
            {
                dpdlAutobus.Items.Add(Convert.ToString(ltAutobus[i].IdAutobus));
            }

        }
    }
}