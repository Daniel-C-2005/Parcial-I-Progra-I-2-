using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_I_Progra_I__2_
{
    using System;

    class Program
    {
        static void Main(string[] args)

        {
            int n;
            bool numVal = false;

            do
            {
                Console.Write("Ingrese un número entero mayor a 0: ");
                string entrada = Console.ReadLine();
               
                    n = int.Parse(entrada);
                    if (n > 0)
                    {
                        numVal = true;
                    }
                    else
                    {
                        Console.WriteLine("El número debe ser mayor a 0. Intente nuevamente.");
                    }
               
                {
                    Console.WriteLine("La entrada no es un número entero válido. Intente nuevamente.");
                }
            } while (!numVal);



            // Calcular el factorial de N
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            // Imprimir el factorial de N
            Console.WriteLine("El factorial de {0} es {1}", n, factorial);

            // Imprimir todos los números enteros positivos menores o iguales que N que sean divisibles entre 3
            Console.Write("Los números enteros positivos menores o iguales que {0} que son divisibles entre 3 son: ", n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();

            // Imprimir todos los números enteros positivos menores o iguales que N que sean divisibles entre 5
            Console.Write("Los números enteros positivos menores o iguales que {0} que son divisibles entre 5 son: ", n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();

            // Imprimir la secuencia de números enteros positivos que comienzan en 1 y se incrementan en 2 hasta que se alcance un valor mayor que N
            Console.Write("La secuencia de números enteros positivos que comienzan en 1 y se incrementan en 2 hasta que se alcance un valor mayor que {0} es: ", n);
            int j = 1;
            while (j <= n)
            {
                Console.Write("{0} ", j);
                j += 2;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
