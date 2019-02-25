using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Pojos
{
    public class PojoGaleria
    {
        int idGaleria, idUsuario;
        string titulo, img_galeria;

        public int IdGaleria { get => idGaleria; set => idGaleria = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Img_galeria { get => img_galeria; set => img_galeria = value; }
    }
}
