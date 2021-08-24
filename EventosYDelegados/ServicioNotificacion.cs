using System;

namespace EventosYDelegados
{
    public class ServicioNotificacion
    {
        public void EnArchivoDescargado(object fuente, EventArgs e)
        {
            Console.WriteLine("Informamos que el archivo se ha terminado de descargar");

        }
    }
}
