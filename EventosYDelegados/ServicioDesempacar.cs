using System;

namespace EventosYDelegados
{
    public class ServicioDesempacar
    {
        public void EnArchivoDescargado(object fuente, EventArgs e)
        {
            Console.WriteLine("ServicioDesempacar: desempacando el archivo...");

        }
    }
}
