using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Pojos
{
    public class PojoImagen
    {
        int idImagen, idGaleria;
        string titulo, descripcion, url, estado;

        public int IdImagen { get => idImagen; set => idImagen = value; }
        public int IdGaleria { get => idGaleria; set => idGaleria = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Url { get => url; set => url = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
