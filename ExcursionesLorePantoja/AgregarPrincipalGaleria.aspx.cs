using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Pojos;

namespace ExcursionesLorePantoja
{
    public partial class AgregarPrincipalGaleria : System.Web.UI.Page
    {
        DaoPrincipalGaleria daoPrincipalGaleria = new DaoPrincipalGaleria();
        PojoPrincipalGaleria pojoPrincipalGaleria = new PojoPrincipalGaleria();

        protected void Page_Load(object sender, EventArgs e)
        {
            //cardarDatos();
        }

        [WebMethod]
        public static List<PojoPrincipal> cardarDatos()
        {
            DaoPrincipalGaleria daoPrincipalGaleria = new DaoPrincipalGaleria();
            List<PojoPrincipal> ltPrincipal = new List<PojoPrincipal>();

            try
            {
                ltPrincipal = daoPrincipalGaleria.obtenerIdPrincipal();
            } catch (Exception ex)
            {
                ltPrincipal = null;
            }

            return ltPrincipal;
            //for (int i = 0; i < ltPrincipal.Count(); i++)
            //{
            //    dpdlIdDescripcion.Items.Add(Convert.ToString(ltPrincipal[i].IdPrincipal));
            //}

        }
        
        //protected void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    string ruta = "";
        //    bool existe;
        //    ruta = Server.MapPath("~/img/imgGaleria");
        //    existe = Directory.Exists(ruta);

        //    try
        //    {
        //        if (!existe)
        //        {
        //            Directory.CreateDirectory(ruta);
        //        }
        //    }
        //    catch { }


        //    if (FileUpload1.HasFile)
        //    {
        //        // se obtiene la extension y el tamaño para delimitar
        //        string ext = Path.GetExtension(FileUpload1.FileName);
        //        ext = ext.ToLower();

        //        int tam = FileUpload1.PostedFile.ContentLength;
                

               
        //        try
        //        {
        //            //si la ruta existe en imgGaleria 
        //            //guardar en principalGaleria
        //            //si no guardar en imgGaleria y en principalGaleria
        //            if (ext == ".png" && tam <= 1048576)
        //            {
        //                FileUpload1.SaveAs(Server.MapPath("~/img/imgGaleria/" + FileUpload1.FileName));
        //                string path = Server.MapPath("~/img/imgGaleria/" + FileUpload1.FileName);

        //                if (daoPrincipalGaleria.obtenerIdGaleria(path))
        //                {
        //                    pojoPrincipalGaleria.IdGaleria = daoPrincipalGaleria.obtenerID(path);
        //                    pojoPrincipalGaleria.IdPrincipal = Convert.ToInt32(dpdlIdDescripcion.SelectedItem.Text);
        //                    pojoPrincipalGaleria.Img = path;
        //                    daoPrincipalGaleria.insertar(pojoPrincipalGaleria);

        //                }
        //                else
        //                {

                           
        //                        FileUpload1.SaveAs(Server.MapPath("~/img/imgGaleria/" + FileUpload1.FileName));

        //                        pojoPrincipalGaleria.IdGaleria = daoPrincipalGaleria.obtenerID(path);
        //                        pojoPrincipalGaleria.IdPrincipal = Convert.ToInt32(dpdlIdDescripcion.SelectedItem.Text);
        //                        pojoPrincipalGaleria.Img = path;
        //                        daoPrincipalGaleria.insertar(pojoPrincipalGaleria);
                            


        //                }
        //            }

                       
        //        } catch { }

        //    }

        //}
        [WebMethod]
        public static List<pojoMostrarGaleria> ListImg()
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
        public static bool insertImagen(string url, string titulo)
        {
            DaoPrincipalGaleria daoPrincipalGaleria = new DaoPrincipalGaleria();
            PojoPrincipalGaleria pojoPrincipalGaleria = new PojoPrincipalGaleria()
            {
                IdGaleria = daoPrincipalGaleria.obtenerID(titulo),
                Img = url

            };

            bool ok = daoPrincipalGaleria.insertar(pojoPrincipalGaleria);
            return ok;
        }

            //protected void FileUpload1_DataBinding(object sender, EventArgs e)
            //{
            //    FileUpload1.AppRelativeTemplateSourceDirectory = Path.Combine("~/img/imgGaleria");
            //}
        }
}