using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Gastos
    {
        private int IdProv;
        private int NroComprobante;
        private DateTime Fecha;
        private int Importe;
        private string Concepto;
        private int IdEdif;

        public int IdProveedor { get => IdProveedor; set => IdProveedor = value; }
        public int NroComprobanteGasto { get => NroComprobante; set => NroComprobante = value; }
        public DateTime FechaGasto { get => Fecha; set => Fecha = value; }
        public int ImporteGasto { get => Importe; set => Importe = value; }
        public string ConceptoGasto { get => Concepto; set => Concepto = value; }
        public int IdEdificio { get => IdEdif; set => IdEdif = value; }
    }
}


