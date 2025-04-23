
using System;

namespace Semana05_FunAlg_13126
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hallar la suma de los primeros n números naturales
            /* 
             int n, suma;
            Console.Write("Ingrese el número de elementos: ");
            n = int.Parse(Console.ReadLine());

            // si n = 6
            // 1 + 2 + 3 + 4 + 5 + 6
            suma = 0;
            for(int i = 1; i<= n; i++)
            {
                //Console.WriteLine("-------\nIteración " + i);
                suma = suma + i;
                //Console.WriteLine("->En esta iteración la suma es: " + suma);
                //Console.ReadKey();
            }
            Console.WriteLine("La suma es: " + suma);
            */

            // Hallar la suma de los cubos de los n numeros naturales
            int n, sumacubos;
            Console.Write("Número de elementos: ");
            n = int.Parse(Console.ReadLine());

            sumacubos = 0;

            for(int i = 1; i <= n; i++) // incremento de uno en uno
            {
                sumacubos = sumacubos + (i * i * i);
                //sumacubos = sumacubos + Math.Pow(i, 3);
            }

            Console.WriteLine("La suma de los cuadrados es: " + sumacubos);

            // Hallar la suma de los n primeros numeros naturales pares
            int n1, sumapares;
            Console.Write("Ingrese numero de elementos: ");
            n1 = int.Parse(Console.ReadLine());
            sumapares = 0;

            //n1=10
            for(int i = 1; i <= n1; i++)
            {
                Console.WriteLine("Hola");
            }
        }
    }
}
