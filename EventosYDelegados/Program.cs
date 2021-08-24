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
            var servivioNotificacion = new ServicioNotificacion();//receptor
            asistenteDescarga.ArchivoDescargado += servicioDesempacar.EnArchivoDescargado;
            asistenteDescarga.ArchivoDescargado += servivioNotificacion.EnArchivoDescargado;
            asistenteDescarga.Descarga(archivo);
            Console.ReadKey();
        }
    }
}
