using System;
using System.IO;
using System.IO.Compression;

namespace ProyectoBackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaInicial = Console.ReadLine();
            string rutaFinal = Console.ReadLine();

            if (!Directory.Exists(rutaInicial)) { System.Diagnostics.Debug.WriteLine("No existe el directorio " + rutaInicial); Console.Read(); return; }

            ZipFile.CreateFromDirectory(rutaInicial, rutaFinal + @"\copia.rar");

            //Agrega el log
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");

            rutaFinal = rutaFinal + @"\log";

            if (!Directory.Exists(rutaFinal)) Directory.CreateDirectory(rutaFinal);

            StreamWriter sw = new StreamWriter(rutaFinal + @"\" + fecha + ".txt", true);
            fecha = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            sw.WriteLine("Fecha: " + fecha);
            sw.Close();
        }
    }
}
