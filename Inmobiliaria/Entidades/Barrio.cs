using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Barrios
    {
        private int IdBarr;
        private string Nombre;
        private int IdLocalidad;

        public Barrios()
        {

        }

        public int IdBarrio { get => IdBarr; set => IdBarr = value; }
        public string NombreBarrio { get => Nombre; set => Nombre = value; }
        public int IdLocalidadBarrio { get => IdLocalidad; set => IdLocalidad = value; }
    }
}
