using System;
using System.Linq;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número: ");
            string numPerfect = Console.ReadLine();

            int num = Convert.ToInt32(numPerfect);
            int[] numbers = new int[num];

            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {                    
                    if (i % j == 0)
                    {
                        sum += j;
                    }

                }

                if(i == sum)
                {
                    Console.WriteLine($"El número {i} es perfecto");
                }

            }
        }
    }
}
