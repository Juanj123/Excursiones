using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Capa_Datos;
using Capa_Pojos;


namespace ExcursionesLorePantoja
{
    public partial class AgregarGaleria : System.Web.UI.Page
    {
        PojoGaleria pojoGaleria = new PojoGaleria();
        DaoGaleria daoGaleria = new DaoGaleria();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRuta_Click(object sender, EventArgs e)
        {
            
            
        }

        
        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            string ruta = "";
            string rutaInicial = "";
            bool existe;
            //HttpPostedFile mifichero;
            //mifichero = FileUpload1.PostedFile;
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
                    string path ="img\\" + FileUpload1.FileName; 

                    pojoGaleria.IdUsuario = 1;
                    pojoGaleria.Titulo = txtNombre.Text;
                    pojoGaleria.Img_galeria = path;

                    daoGaleria.insertar(pojoGaleria);

                    Response.Redirect("PrincipalGaleria.aspx");
                }
            }
            else
            {
               
            }
            //if (File.Exists(rutaInicial))
            //{
            //    File.Copy(rutaInicial, ruta, true);
            //}
        }
    }
}