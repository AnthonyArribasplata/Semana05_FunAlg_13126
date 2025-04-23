using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Indicar si un número es perfecto, 
            cuando la suma de sus divisores es 
            igual al número. 
            Por ejemplo 6, tiene como divisores 
            a 1,2 y 3, luego 1+2+3=6.
             */

            int num;
            int suma=0;

            Console.Write("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());

            for (int x = 1; x < num; x++)
            {
                //mod => %
                if (num % x==0)
                {
                    //aqui
                    //Console.WriteLine(x);
                    suma = suma + x;
                }
            }
            //Console.WriteLine("Suma: "+suma);
            if (num==suma)
            {
                Console.WriteLine("Si es perfecto");
            } else
            {
                Console.WriteLine("No es perfecto");
            }
        }
    }
}
