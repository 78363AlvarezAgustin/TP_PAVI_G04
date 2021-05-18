using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class TipoDoc
    {
        private int id;
        private string nombreTipoDocumento;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string NombreTipoDocumento
        {
            get => nombreTipoDocumento;
            set => nombreTipoDocumento = value;
        }
    }
}
