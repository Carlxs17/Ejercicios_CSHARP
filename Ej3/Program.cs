using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                // Usamos la función en el if
                if (EsPrimo(numero) == 1)
                    Console.WriteLine($"El número {numero} es primo.");
                else
                    Console.WriteLine($"El número {numero} no es primo.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
            }
        }

        // Función que devuelve 1 si es primo, 0 si no lo es
        static int EsPrimo(int n)
        {
            if (n <= 1) return 0;
            if (n == 2) return 1;
            if (n % 2 == 0) return 0;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                    return 0;
            }

            return 1;
        }
    }
}
