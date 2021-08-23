using System;

namespace EventosYDelegados
{
    class Program
    {
        static void Main(string[] args)
        {
            var archivo = new Archivo() { Titulo = "Archivo 1"};
            var asistenteDescarga = new AsistenteDescarga(); //emisor

            asistenteDescarga.Descarga(archivo);
        }
    }
}
