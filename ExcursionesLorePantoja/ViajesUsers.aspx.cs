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
    public partial class ViajesUsers : System.Web.UI.Page
    {
        DatosViajes da = new DatosViajes();
        List<PojoViajes> lis = new List<PojoViajes>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                lis = da.obtenerViajes();

                for (int i = 0; i < lis.Count; i++)
                {
                    ltViajes.Text += "<div class='promo' style='float:left; overflow: hidden; margin-left: 25px; margin-top: 15px;'><div class='imge'><img src = 'img/benches.jpg' style='width: 400px; height: 200px;'></div> <h3>" + lis[i].Destino + "</h3><div class='txt'><p class='text-justify pe'>BALNEARIO LA GRUTA👙 Y A DISFRUTAR DE UNA TARDE EN SAN MIGUEL DE ALLENDE🏦 DOMINGO 12 DE MAYO 2019 Vamos a disfrutar de las aguas termales del balneario la gruta en San Miguel de Allende y como el lugar lo cierran temprano nos vamos a disfrutar de una tarde-noche en San Miguel de Allende..te late ?? !!</p> </div><div class='pi' style='overflow: hidden;'> <h4 style = 'float:left'>" + lis[i].Costoadulto + "</h4><Button class='btn btn-success btnIdViaje'  data-id='"+lis[i].Idviaje+"'  style='float:right'><i class='fas fa-bus'></i> Reservar</Button></div></div>";
                }

            }
            rbndestino.Checked = true;
        }

        protected void txtbuscarviaje_TextChanged(object sender, EventArgs e)
        {
            if (rbndestino.Checked == true)
            {
                ltViajes.Text = "";
                List<PojoViajes> lista = new List<PojoViajes>();
                lista = da.getDatosProductobynombre(txtbuscarviaje.Text);
                if (lista.Count == 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertIns", "alert('No se encuntran registros a ese detino');", true);
                }
                else
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        ltViajes.Text += "<div class='promo' style='float:left; overflow: hidden; margin-left: 25px; margin-top: 15px;'><div class='imge'><img src = 'img/benches.jpg' style='width: 400px; height: 200px;'></div> <h3>" + lista[i].Destino + "</h3><div class='txt'><p class='text-justify pe'>Una mañana, tras un sueño intranquilo, Gregorio Samsa se despertó convertido en un monstruoso insecto.Estaba echado de espaldas sobre un duro caparazón y, al alzar la cabeza, vio su vientreconvexo y oscuro, surcado por curvadas callosidades, sobre el que casi no se aguantaba la colcha.</p> </div><div class='pi' style='overflow: hidden;'> <h4 style = 'float:left'>" + lista[i].Costoadulto + "</h4><Button class='btn btn-success'  onclick='myFunction()'  style='float:right'><i class='fas fa-bus'></i> Reservar</Button></div></div>";
                    }
                }

                //for (int i = 0; i < lista.Count; i++)
                //{
                //    ltViajes.Text += "<div class='promo' style='float:left; overflow: hidden; margin-left: 25px; margin-top: 15px;'><div class='imge'><img src = 'img/benches.jpg' style='width: 400px; height: 200px;'></div> <h3>" + lista[i].Destino + "</h3><div class='txt'><p class='text-justify pe'>Una mañana, tras un sueño intranquilo, Gregorio Samsa se despertó convertido en un monstruoso insecto.Estaba echado de espaldas sobre un duro caparazón y, al alzar la cabeza, vio su vientreconvexo y oscuro, surcado por curvadas callosidades, sobre el que casi no se aguantaba la colcha.</p> </div><div class='pi' style='overflow: hidden;'> <h4 style = 'float:left'>" + lista[i].Costoadulto + "</h4><Button class='btn btn-success'  onclick='myFunction()'  style='float:right'><i class='fas fa-bus'></i> Reservar</Button></div></div>";
                //}
            }
            txtbuscarviaje.Text = "";
            txtbuscarviaje.Focus();
            

        }
        [System.Web.Services.WebMethod]
        public static void setIdViaje(string idViaje)
        {
            apartaTuLugar apartaTuLugar = new apartaTuLugar();
            apartaTuLugar.idViajes = Convert.ToInt32(idViaje);
           
            string a;
           
        }
    }
}