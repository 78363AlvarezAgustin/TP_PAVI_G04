using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Expensas
    {

        private int IdEdificio;
        private int mes;
        private int ano;
        private int importe;

        public int IdDeEdificio { get => IdEdificio; set => IdEdificio = value; }
        public int mesExpensa { get => mes; set => mes = value; }
        public int anoExpensa { get => ano; set => ano = value; }
        public int importeExpensa { get => importe; set => importe = value; }

    }
}

