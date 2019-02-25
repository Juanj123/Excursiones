using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace ExcursionesLorePantoja
{
    public partial class PruebaImagen : System.Web.UI.Page
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;username=root;password=root");
        MySqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEscoger_Click(object sender, EventArgs e)
        {
            string sentencia = "select img from prueba.imagen;";
            MySqlDataReader myReader;
            FileStream fs;                          // Writes the BLOB to a file (*.bmp).
            BinaryWriter bw;                        // Streams the BLOB to the FileStream object.
            int bufferSize = 100;                   // Size of the BLOB buffer.
            byte[] outbyte = new byte[bufferSize];  // The BLOB byte[] buffer to be filled by GetBytes.
            long retval;                            // The bytes returned from GetBytes.
            long startIndex = 0;                    // The starting position in the BLOB output.

            // Open the connection and read data into the DataReader.
            connection.Open();
            command = new MySqlCommand(sentencia, connection);
            
            myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                // Create a file to hold the output.
                fs = new FileStream("C:/Users/laser/Documents/ExcursionesLore/ExcursionesLorePantoja/imgPrueba/hola.jpg", FileMode.OpenOrCreate, FileAccess.Write);
                bw = new BinaryWriter(fs);

                // Reset the starting byte for the new BLOB.
                startIndex = 0;

                // Read the bytes into outbyte[] and retain the number of bytes returned.
                retval = myReader.GetBytes(0, startIndex, outbyte, 0, bufferSize);

                // Continue reading and writing while there are bytes beyond the size of the buffer.
                while (retval == bufferSize)
                {
                    bw.Write(outbyte);
                    bw.Flush();

                    // Reposition the start index to the end of the last buffer and fill the buffer.
                    startIndex += bufferSize;
                    retval = myReader.GetBytes(0, startIndex, outbyte, 0, bufferSize);
                }

                // Write the remaining buffer.
                bw.Write(outbyte, 0, (int)retval);
                bw.Flush();

                // Close the output file.
                bw.Close();
                fs.Close();
                 }
            string archivo = "/imgPrueba/hola.jpg";
            pictureBox1.ImageUrl = archivo;
            }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            HttpPostedFile pf = FileUpload1.PostedFile;
            string filename = Path.GetFileName(pf.FileName);
            string filext = Path.GetExtension(filename);
            int size = pf.ContentLength;
            if(filext.ToLower()==".jpg" || filext.ToLower() == ".png")
            {
                Stream stream = pf.InputStream;
                BinaryReader br = new BinaryReader(stream);
                byte[] img = br.ReadBytes((int)stream.Length);
                String insertQuery = "insert into prueba.imagen() value(@img);";
                connection.Open();
                command = new MySqlCommand(insertQuery, connection);
                command.Parameters.Add("@img", MySqlDbType.LongBlob);
                command.Parameters["@img"].Value = img;
                if (command.ExecuteNonQuery() == 1)
                {
                    string script = "alert('Registro Exitoso');";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            connection.Close();
        }

   
    }
}