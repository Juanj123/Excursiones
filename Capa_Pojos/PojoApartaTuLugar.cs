using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Pojos
{
    public class PojoApartaTuLugar
    {
        int idUsuario, idAutobus, n_Asiento, idReservacion, idViaje, nota;
        Double costo_adulto, costoNino;
        String destino, img;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdAutobus { get => idAutobus; set => idAutobus = value; }
        public int N_Asiento { get => n_Asiento; set => n_Asiento = value; }
        public int IdReservacion { get => idReservacion; set => idReservacion = value; }
        public int IdViaje { get => idViaje; set => idViaje = value; }
        public int Nota { get => nota; set => nota = value; }
        public double Costo_adulto { get => costo_adulto; set => costo_adulto = value; }
        public double CostoNino { get => costoNino; set => costoNino = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Img { get => img; set => img = value; }
    }
}
