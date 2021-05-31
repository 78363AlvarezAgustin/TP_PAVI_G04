using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Recibo
    {

        private int Id;
        private DateTime FechaCobro;
        private int Importe;
        private int MesExpensa;
        private int AñoExpensa;
        private int LegajoEncargadoExp;
        private int IdEdificio;
        private int Piso;
        private string Denominacion;

        public int IdRecibo { get => Id; set => Id = value; }
        public DateTime FechaCobroRecibo { get => FechaCobro; set => FechaCobro = value; }
        public int ImporteRecibo { get => Importe; set => Importe = value; }
        public int MesExpensaRecibo { get => MesExpensa; set => MesExpensa = value; }
        public int AñoExpensaRecibo { get => AñoExpensa; set => AñoExpensa = value; }
        public int LegajoEncargadoExpRecibo { get => LegajoEncargadoExp; set => LegajoEncargadoExp = value; }
        public int IdEdificioRecibo { get => IdEdificio; set => IdEdificio = value; }
        public int PisoRecibo { get => Piso; set => Piso = value; }
        public string DenominacionRecibo { get => Denominacion; set => Denominacion = value; }

    }
}
