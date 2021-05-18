using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class MediosPago
    {
        private int Id;
        private string Nombre;
        private string Descripcion;

        public int IdPago { get => Id; set => Id = value; }
        public string NombrePago { get => Nombre; set => Nombre = value; }
        public string DescripcionPago { get => Descripcion; set => Descripcion = value; }
    }
}
