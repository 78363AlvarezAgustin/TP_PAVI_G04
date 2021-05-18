using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class MedioPublicidad
    {
        private int id;
        private string nombreMedioPublicitario;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string NombreMedioPublicitario
        {
            get => nombreMedioPublicitario;
            set => nombreMedioPublicitario = value;
        }
    }
}
