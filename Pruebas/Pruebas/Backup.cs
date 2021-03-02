using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Backup
    {
        private Comando utiles;
        private string nombre;
        private string rutaOrigen;
        private string rutaDestino;
        private bool forzarCierre;

        public Backup(string nombre, string rutaOrigen, string rutaDestino, bool repliacion, bool forzarCierre = false ) {
            this.nombre = nombre;
            this.rutaOrigen = rutaOrigen;
            this.rutaDestino = rutaDestino;
            this.forzarCierre = forzarCierre;

            utiles = new ComandoBasico();
        }

        public void mostrar()
        {
            Console.WriteLine(nombre + " "+rutaOrigen+" "+rutaDestino+ " "+forzarCierre);
        }
    }
}
