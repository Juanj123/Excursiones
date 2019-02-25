using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Pojos
{
    public class PojoOfertas
    {
        int idOferta, idViaje;
        double costo_adulto, costo_niño;

        public int IdOferta { get => idOferta; set => idOferta = value; }
        public int IdViaje { get => idViaje; set => idViaje = value; }
        public double Costo_adulto { get => costo_adulto; set => costo_adulto = value; }
        public double Costo_niño { get => costo_niño; set => costo_niño = value; }
    }
}
