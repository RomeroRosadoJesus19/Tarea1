using Jesus.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Jesus.Service
{
    public class Compra
    {
        public string Datos()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Ingrese Su Nombre");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Su Apedillo");
            cliente.Apedillo = Console.ReadLine();
            Console.WriteLine("Ingrese Su Correo");
            cliente.Correo = Console.ReadLine();
            Console.WriteLine("Ingrese Su Telefono");
            cliente.Telefono = Console.ReadLine();

            string datosCompletos = $"{cliente.Nombre} {cliente.Apedillo}, {cliente.Correo}, {cliente.Telefono}";
            return datosCompletos;

        }
        public void Suma()
        {

            Console.WriteLine("Ingrese Articulo1");
            int articulo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Articulo2");
            int articulo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Articulo3");
            int articulo3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Articulo4");
            int articulo4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Articulo5");
            int articulo5 = int.Parse(Console.ReadLine());

            int suma = articulo1 + articulo2 + articulo3 + articulo4 + articulo5;

            double pagoMensual; // Declarar la variable fuera del switch 

            switch (true)
            {
                case var _ when suma >= 5000 && suma < 8000://Lo condicione  para que no pase el valor del precio determinado
                    Console.WriteLine("El total de la compra sería mayor a $5000. Se ofrece un 10% de descuento.");
                    double descuento = suma * 0.10;
                    double totalConDescuento = suma - descuento;
                    Console.WriteLine($"Se pagará ${totalConDescuento}");
                    break;
                case var _ when suma >= 8000 && suma < 10000://Lo condicione  para que no pase el valor del precio determinado
                    Console.WriteLine("El total de la compra es mayor a $8000. Se ofrecen 3 meses sin intereses.");
                    pagoMensual = suma / 3; // Asignar el valor a la variable declarada
                    Console.WriteLine($"Total: ${suma}");
                    Console.WriteLine($"Se pagará ${pagoMensual} cada mes durante 3 meses.");
                    break;
                case var _ when suma >= 10000: //Lo condicione  para que no pase el valor del precio determinado
                    Console.WriteLine("El total de la compra es mayor a $10000. ¿Desea 3 o 6 meses sin intereses? Ingrese el número correspondiente.");
                    int meses = int.Parse(Console.ReadLine());
                    pagoMensual = suma / meses; // Asignar el valor a la variable declarada
                    Console.WriteLine($"Total: ${suma}");
                    Console.WriteLine($"Se pagará ${pagoMensual} cada mes durante {meses} meses.");
                    break;
                default:
                    Console.WriteLine("El total de la compra es menor o igual a $10000. No se aplica ningún plan de pagos sin intereses.");
                    break;
            }
        }
    }
}
