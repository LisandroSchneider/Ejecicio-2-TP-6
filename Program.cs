using System;

namespace Ejercicio_n_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Escriba su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("¡Bienvenido {0}!",nombre);

            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();
        }
    }
}
