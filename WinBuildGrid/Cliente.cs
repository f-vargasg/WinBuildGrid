using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBuildGrid
{
    class Cliente
    {

        private static int lastCodClienteN =0;
        public int CodClienteN { get;}
        public string Nombre { get; set; }


        public Cliente( string pNombre)
        {

            this.CodClienteN = ++lastCodClienteN;
            this.Nombre = pNombre;

        }
    }
}
