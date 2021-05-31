using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Entidades
{
    public class Clientes
    {
        private int NroDocumento;
        private int TipoDocumento;
        private string Nombre;
        private string Apellido;
        private int Telefono;
        private string Calle;
        private int NroCalle;
        private int IdBarrio;

        public int NroDocumentoClientes { get => NroDocumento; set => NroDocumento = value; }
        public int TipoDocumentoClientes { get => TipoDocumento; set => TipoDocumento = value; }
        public string NombreClientes { get => Nombre; set => Nombre = value; }
        public string ApellidoClientes { get => Apellido; set => Apellido = value; }
        public int TelefonoClientes { get => Telefono; set => Telefono = value; }
        public string CalleClientes { get => Calle; set => Calle = value; }
        public int NroCalleClientes { get => NroCalle; set => NroCalle = value; }
        public int IdBarrioClientes { get => IdBarrio; set => IdBarrio = value; }
    }
}
