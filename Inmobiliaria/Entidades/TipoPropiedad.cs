using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class TipoPropiedad
    {
        private int id;
        private string nombreTipoPropiedad;
        private string descripcion;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string NombreTipoPropiedad
        {
            get => nombreTipoPropiedad;
            set => nombreTipoPropiedad = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}
