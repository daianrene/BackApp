using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    abstract class Comando
    {

        public bool comprimir(string nombreArchivo, string origen) {
            return true;
        }

        public bool copiar(string nombreArchivo, string origen, string destino) {
            return true;
        }

        public bool borrarXFechaDeCreacionDias(int diferencia) {
            return true;
        }

        public bool borrarXFechaDeCreacionSemanas(int diferencia){
            return true;
        }

        public bool borrarXFechaDeCreacionAnios(int diferencia){
            return true;
        }
    }
}
