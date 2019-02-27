
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using Newtonsoft.Json;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Web.Services;
using Capa_Datos;
using Capa_Pojos;
using System.Text;

namespace ExcursionesLorePantoja
{

    public partial class apartaTuLugar : System.Web.UI.Page
    {
        DatosRegistroClientes datosRegistroClientes = new DatosRegistroClientes();
        DaoApartaTuLugar dao = new DaoApartaTuLugar();
        List<PojoUsuarios> pojos = new List<PojoUsuarios>();
        List<int> lugares = new List<int>();
        string valores;
        string totalPagar;
        int idAutobus = 0;
        public static int idViajes;
        //[System.Web.Services.WebMethod]
        //public static int setIdViaje(string idViaje)
        //{

        //    return Convert.ToInt32(idViaje);
        //}

        private void RegistrarScript()
        {
            const string ScriptKey = "ScriptKey";
            if (!ClientScript.IsStartupScriptRegistered(this.GetType(), ScriptKey))
            {
                StringBuilder fn = new StringBuilder();
                fn.Append("llenarAutobus();");
                ClientScript.RegisterStartupScript(this.GetType(),
        ScriptKey, fn.ToString(), true);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert(' idViaje= "+idViajes+"');", true);
            DaoApartaTuLugar objDaoAparta = new DaoApartaTuLugar();
            lblPrecioAdulto1.Text = objDaoAparta.getDatosViaje(idViajes)[0].Costo_adulto.ToString();
            lblPrecioNino1.Text = objDaoAparta.getDatosViaje(idViajes)[0].CostoNino.ToString();
            lblDestino.Text = objDaoAparta.getDatosViaje(idViajes)[0].Destino.ToString();
            var lista = objDaoAparta.getAsientosOcupados(idViajes);
            var Json = JsonConvert.SerializeObject(lista);
            Response.Cookies["asientosAutobus"].Value = Json;
            idAutobus = dao.getTipoAutobus(idViajes);

        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            int idUsuario = dao.getIdUsuario(Session["login"].ToString());
            idAutobus = dao.getTipoAutobus(idViajes);
            totalPagar = Request.Cookies["Total"].Value;
            valores = Request.Cookies["Asientos"].Value;
            string[] asientos = valores.Split(',');
            foreach (string word in asientos)
            {
                if (Regex.IsMatch(word, "(48)"))
                {
                    lugares.Add(48);
                }
                if (Regex.IsMatch(word, "(47)"))
                {
                    lugares.Add(47);
                }
                if (Regex.IsMatch(word, "(46)"))
                {
                    lugares.Add(46);
                }
                if (Regex.IsMatch(word, "(45)"))
                {
                    lugares.Add(45);
                }
                if (Regex.IsMatch(word, "(44)"))
                {
                    lugares.Add(44);
                }
                if (Regex.IsMatch(word, "(43)"))
                {
                    lugares.Add(43);
                }
                if (Regex.IsMatch(word, "(42)"))
                {
                    lugares.Add(42);
                }
                if (Regex.IsMatch(word, "(41)"))
                {
                    lugares.Add(41);
                }
                if (Regex.IsMatch(word, "(40)"))
                {
                    lugares.Add(40);
                }
                if (Regex.IsMatch(word, "(39)"))
                {
                    lugares.Add(39);
                }
                if (Regex.IsMatch(word, "(38)"))
                {
                    lugares.Add(38);
                }
                if (Regex.IsMatch(word, "(37)"))
                {
                    lugares.Add(37);
                }
                if (Regex.IsMatch(word, "(36)"))
                {
                    lugares.Add(36);
                }
                if (Regex.IsMatch(word, "(35)"))
                {
                    lugares.Add(35);
                }
                if (Regex.IsMatch(word, "(34)"))
                {
                    lugares.Add(34);
                }
                if (Regex.IsMatch(word, "(33)"))
                {
                    lugares.Add(33);
                }
                if (Regex.IsMatch(word, "(32)"))
                {
                    lugares.Add(32);
                }
                if (Regex.IsMatch(word, "(31)"))
                {
                    lugares.Add(31);
                }
                if (Regex.IsMatch(word, "(30)"))
                {
                    lugares.Add(30);
                }
                if (Regex.IsMatch(word, "(29)"))
                {
                    lugares.Add(29);
                }
                if (Regex.IsMatch(word, "(28)"))
                {
                    lugares.Add(28);
                }
                if (Regex.IsMatch(word, "(27)"))
                {
                    lugares.Add(27);
                }
                if (Regex.IsMatch(word, "(26)"))
                {
                    lugares.Add(26);
                }
                if (Regex.IsMatch(word, "(25)"))
                {
                    lugares.Add(25);
                }
                if (Regex.IsMatch(word, "(24)"))
                {
                    lugares.Add(24);
                }
                if (Regex.IsMatch(word, "(23)"))
                {
                    lugares.Add(23);
                }
                if (Regex.IsMatch(word, "(22)"))
                {
                    lugares.Add(22);
                }
                if (Regex.IsMatch(word, "(21)"))
                {
                    lugares.Add(21);
                }
                if (Regex.IsMatch(word, "(20)"))
                {
                    lugares.Add(20);
                }
                if (Regex.IsMatch(word, "(19)"))
                {
                    lugares.Add(19);
                }
                if (Regex.IsMatch(word, "(18)"))
                {
                    lugares.Add(18);
                }
                if (Regex.IsMatch(word, "(17)"))
                {
                    lugares.Add(17);
                }
                if (Regex.IsMatch(word, "(16)"))
                {
                    lugares.Add(16);
                }
                if (Regex.IsMatch(word, "(15)"))
                {
                    lugares.Add(15);
                }
                if (Regex.IsMatch(word, "(14)"))
                {
                    lugares.Add(14);
                }
                if (Regex.IsMatch(word, "(13)"))
                {
                    lugares.Add(13);
                }
                if (Regex.IsMatch(word, "(12)"))
                {
                    lugares.Add(12);
                }
                if (Regex.IsMatch(word, "(11)"))
                {
                    lugares.Add(11);
                }
                if (Regex.IsMatch(word, "(10)"))
                {
                    lugares.Add(10);
                }
                if (Regex.IsMatch(word, "(9)"))
                {
                    if (lugares.Contains(19) || lugares.Contains(29) || lugares.Contains(39))
                    {
                        continue;
                    }
                    lugares.Add(9);
                }
                if (Regex.IsMatch(word, "(8)"))
                {
                    if (lugares.Contains(18) || lugares.Contains(28) || lugares.Contains(38) || lugares.Contains(48))
                    {
                        continue;
                    }
                    lugares.Add(8);
                }
                if (Regex.IsMatch(word, "(7)"))
                {
                    if (lugares.Contains(17) || lugares.Contains(27) || lugares.Contains(37) || lugares.Contains(47))
                    {
                        continue;
                    }
                    lugares.Add(7);
                }
                if (Regex.IsMatch(word, "(6)"))
                {
                    if (lugares.Contains(16) || lugares.Contains(26) || lugares.Contains(36) || lugares.Contains(46))
                    {
                        continue;
                    }
                    lugares.Add(6);
                }
                if (Regex.IsMatch(word, "(5)"))
                {
                    if (lugares.Contains(15) || lugares.Contains(25) || lugares.Contains(35) || lugares.Contains(45))
                    {
                        continue;
                    }
                    lugares.Add(5);
                }
                if (Regex.IsMatch(word, "(4)"))
                {
                    if (lugares.Contains(40) || lugares.Contains(41) || lugares.Contains(42) || lugares.Contains(43)
                        || lugares.Contains(44) || lugares.Contains(45) || lugares.Contains(46) || lugares.Contains(47)
                        || lugares.Contains(48) || lugares.Contains(14) || lugares.Contains(24) || lugares.Contains(34))
                    {
                        continue;
                    }
                    lugares.Add(4);
                }
                if (Regex.IsMatch(word, "(3)"))
                {
                    if (lugares.Contains(30) || lugares.Contains(31) || lugares.Contains(32) || lugares.Contains(33)
                        || lugares.Contains(34) || lugares.Contains(35) || lugares.Contains(36) || lugares.Contains(37)
                        || lugares.Contains(38) || lugares.Contains(39) || lugares.Contains(13) || lugares.Contains(43))
                    {
                        continue;
                    }
                    lugares.Add(3);
                }
                if (Regex.IsMatch(word, "(2)"))
                {
                    if (lugares.Contains(20) || lugares.Contains(21) || lugares.Contains(22) || lugares.Contains(23)
                        || lugares.Contains(24) || lugares.Contains(25) || lugares.Contains(26) || lugares.Contains(27)
                        || lugares.Contains(28) || lugares.Contains(29)|| lugares.Contains(12)|| lugares.Contains(32)
                        || lugares.Contains(42))
                    {
                        continue;
                    }
                    lugares.Add(2);
                }
                if (Regex.IsMatch(word, "(1)"))
                {
                    if (lugares.Contains(10)|| lugares.Contains(11)|| lugares.Contains(12)|| lugares.Contains(13)
                        || lugares.Contains(14)|| lugares.Contains(15)|| lugares.Contains(16)|| lugares.Contains(17)
                        || lugares.Contains(18)|| lugares.Contains(19))
                    {
                        continue;
                    }
                    lugares.Add(1);
                }
            }
            PojoApartaTuLugar objAparta = new PojoApartaTuLugar();
            DaoApartaTuLugar objDaoAparta = new DaoApartaTuLugar();
            objAparta.IdUsuario = idUsuario;
            objAparta.IdAutobus = idAutobus;
            objAparta.IdViaje = idViajes;
            objAparta.TotalPagar = double.Parse(totalPagar);
            foreach (int asiento in lugares)
            {
                objAparta.N_Asiento = asiento;
                objDaoAparta.registrarAsientos(objAparta);
            }
            objDaoAparta.registrarReservacion(objAparta);
            objDaoAparta.registrarReservacionUsuario(objAparta);
            Response.Redirect("apartaTuLugar.aspx");
        }
        [WebMethod]
        public static void asientos()
        {
            List<int> lugares = new List<int>();

        }
    }
}
