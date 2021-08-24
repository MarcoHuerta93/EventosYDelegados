using System;
using System.Threading;

namespace EventosYDelegados
{
  public class AsistenteDescarga
    {
        //Paso 1 crear el delegado
        public delegate void GestorEventoArchivoDescargado(object fuente, EventArgs args);

        //Paso 2 Crear el evento basado en el delegado
        public event GestorEventoArchivoDescargado ArchivoDescargado;

        //Paso 3 Iniciar el evento

        protected virtual void EnArchivoDescargado()
        {
            if (ArchivoDescargado != null) {
                ArchivoDescargado(this, EventArgs.Empty);
            }
        }


        public void Descarga(Archivo archivo)
        {
            Console.WriteLine("Descargando Archivo...");
            Thread.Sleep(4000);

            //Paso 3.1
            EnArchivoDescargado();
        }
       
    }
}
