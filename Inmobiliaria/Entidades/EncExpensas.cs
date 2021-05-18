using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class EncExpensas
    {
        private int Legajo;
        private string Nombre;
        private string Apellido;
        private int Telefono;

        public int LegajoEncExpensas { get => Legajo; set => Legajo = value; }
        public string NombreEncExpensas { get => Nombre; set => Nombre = value; }
        public string ApellidoEncExpensas { get => Apellido; set => Apellido = value; }
        public int TelefonoEncExpensas { get => Telefono; set => Telefono = value; }
    }
}
