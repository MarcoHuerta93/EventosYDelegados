using System;

namespace EventosYDelegados
{
    class Program
    {
        static void Main(string[] args)
        {
            var archivo = new Archivo() { Titulo = "Archivo 1"};
            var asistenteDescarga = new AsistenteDescarga(); //emisor
            var servicioDesempacar = new ServicioDesempacar();//receptor

            asistenteDescarga.ArchivoDescargado += servicioDesempacar.EnArchivoDescargado;

            asistenteDescarga.Descarga(archivo);
            Console.ReadKey();
        }
    }

    public class ServicioDesempacar
    {
        public void EnArchivoDescargado(object fuente, EventArgs e)
        {
            Console.WriteLine("ServicioDesempacar: desempacando el archivo...");

        }
    }
}
