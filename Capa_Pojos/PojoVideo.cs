using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Pojos
{
    public class PojoVideo
    {
        int idVideo, idUsuario;
        string nombre, estado, url;

        public int IdVideo { get => idVideo; set => idVideo = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Url { get => url; set => url = value; }
    }
}
