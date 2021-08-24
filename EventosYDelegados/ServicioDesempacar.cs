using System;

namespace EventosYDelegados
{
    public class ServicioDesempacar
    {
        public void EnArchivoDescargado(object fuente, ArchivoEventArgs e)
        {
            Console.WriteLine("ServicioDesempacar: desempacando el archivo..." + e.Archivo.Titulo);

        }
    }
}
