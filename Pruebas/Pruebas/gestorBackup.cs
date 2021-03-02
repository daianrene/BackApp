using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class gestorBackup
    {
        private XDocument rootFile;
        private List<Backup> cBackups;

        public gestorBackup(string rootFile) {
            this.rootFile = XDocument.Load(rootFile,LoadOptions.None);
            this.cBackups = new List<Backup>();
        }

        public void mostrar() {
            foreach(Backup aux in cBackups)
            {
                aux.mostrar();
            }

        }
        public void loadBackups() {

            foreach (var backup in rootFile.Descendants("Backup")) {

                if( backup.Element("ejecutar").Value == "1"){   
                    string nombre = backup.Element("nombreBackup").Value;
                    string origen = backup.Element("origen").Value;
                    string destino = backup.Element("destino").Value;
                    bool replicacion = (backup.Element("replicacion").Value == "1") ? true : false;
                    

                    Backup aux = new Backup(nombre, origen, destino, replicacion);
                    cBackups.Add(aux);

                }

            }

        }
       
        

    }
}
