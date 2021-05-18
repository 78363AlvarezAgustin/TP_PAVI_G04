using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Dueños
    {
        int nro_documento;
        int tipo_documento;
        string n_dueño;
        string apellido_dueño;
        string calle;
        int nro_calle;
        int id_barrio;

        public int NumeroDocumentoDueño
        {
            get => nro_documento;
            set => nro_documento = value;
        }
        public int TipoDocumentoDueño
        {
            get => tipo_documento;
            set => tipo_documento = value;
        }

        public string NombreDueño
        {
            get => n_dueño;
            set => n_dueño = value;
        }
        public string ApellidoDueño
        {
            get => apellido_dueño;
            set => apellido_dueño = value;
        }
        public string CalleDueño
        {
            get => calle;
            set => calle = value;
        }
        public int NumeroCalleDueño
        {
            get => nro_calle;
            set => nro_calle = value;
        }
        public int IdBarrioDueño
        {
            get => id_barrio;
            set => id_barrio = value;
        }
    }
}
