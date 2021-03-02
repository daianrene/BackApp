using System;
using System.IO;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            string rf = @"C:\Users\Daian\source\repos\Pruebas\Pruebas\FileSincro.xml";
            gestorBackup gb = new gestorBackup(rf);

            gb.loadBackups();
            gb.mostrar();
        }
    }
}
