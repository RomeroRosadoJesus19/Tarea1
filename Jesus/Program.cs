using Jesus.Entity;
using Jesus.Service;
using System;

namespace Actividad_Majo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Compra compra = new Compra();
            compra.Datos();
            compra.Suma();
        }
    }
}
