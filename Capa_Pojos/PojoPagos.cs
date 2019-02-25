using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Pojos
{
    public class PojoPagos
    {
        int idPagos, idReservacion, idUsuario;
        double monto;
        string fecha_pago, estado;
        byte[] img_ticket;

        public int IdPagos { get => idPagos; set => idPagos = value; }
        public int IdReservacion { get => idReservacion; set => idReservacion = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public double Monto { get => monto; set => monto = value; }
        public string Fecha_pago { get => fecha_pago; set => fecha_pago = value; }
        public string Estado { get => estado; set => estado = value; }
        public byte[] Img_ticket { get => img_ticket; set => img_ticket = value; }
    }
}
