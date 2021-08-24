using System;

namespace EventosYDelegados
{
    public class ServicioNotificacion
    {
        public void EnArchivoDescargado(object fuente, ArchivoEventArgs e)
        {
            Console.WriteLine("Informamos que el archivo " + e.Archivo.Titulo + " se ha terminado de descargar");

        }
    }
}
