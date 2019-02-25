using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Pojos
{
    public class PojoAutobus
    {
        int idAutobus, nAsientos;
        string nombre;

        public int IdAutobus { get => idAutobus; set => idAutobus = value; }
        public int NAsientos { get => nAsientos; set => nAsientos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
