using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Publicidad
    {
        private DateTime fecha;
        private int DesigCatastral;
        private int IdMedio;
        private string Descripcion;
        private int Costo;
        private int IdSeccion;

        public DateTime FechaPubli { get => fecha; set => fecha = value; }
        public int DesigCatastralPubli { get => DesigCatastral; set => DesigCatastral = value; }
        public int IdMedioPubli { get => IdMedio; set => IdMedio = value; }
        public string DescripcionPubli { get => Descripcion; set => Descripcion = value; }
        public int CostoPubli { get => Costo; set => Costo = value; }
        public int IdSeccionPubli { get => IdSeccion; set => IdSeccion = value; }
    }
}
