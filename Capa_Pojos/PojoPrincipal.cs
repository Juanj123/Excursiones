using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Pojos
{
    public class PojoPrincipal
    {
        int idPrincipal, idUsuario;
        string descripcion, estado;

        public int IdPrincipal { get => idPrincipal; set => idPrincipal = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
