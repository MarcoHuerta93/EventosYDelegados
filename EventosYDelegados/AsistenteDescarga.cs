using System;
using System.Threading;

namespace EventosYDelegados
{
  public class AsistenteDescarga
    {
        public delegate void GestorEventoArchivoDescargado(object fuente, EventArgs args);



        public void Descarga(Archivo archivo)
        {
            Console.WriteLine("Descargando Archivo...");
            Thread.Sleep(4000);

        }
       
    }
}
