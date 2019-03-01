using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Pojos
{
    public class PojoViajes
    {
        int idviaje;
        byte[] img;
        int idautobus;
        string destino;
        string horaregreso;
        string horasalida;
        double costoadulto;
        double costonino;
        string descripcion;
        int dia, mes, año;
        string nota;

        public int Idviaje { get => idviaje; set => idviaje = value; }
        public byte[] Img { get => img; set => img = value; }
        public int Idautobus { get => idautobus; set => idautobus = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Horaregreso { get => horaregreso; set => horaregreso = value; }
        public string Horasalida { get => horasalida; set => horasalida = value; }
        public double Costoadulto { get => costoadulto; set => costoadulto = value; }
        public double Costonino { get => costonino; set => costonino = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Año { get => año; set => año = value; }
        public string Nota { get => nota; set => nota = value; }
    }
}
