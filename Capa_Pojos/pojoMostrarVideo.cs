using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Pojos
{
    public class pojoMostrarVideo
    {
        string nombre, estado, url;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Url { get => url; set => url = value; }
    }
}
