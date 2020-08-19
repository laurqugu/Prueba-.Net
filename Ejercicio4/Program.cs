using System;
using System.Linq;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero");
            string numero = Console.ReadLine();
            int c = numero.Where(x => Convert.ToInt16(x) % 2 == 0).Count();
            //Console.WriteLine("La cantidad de pares del numero " + numero + "es " + c.ToString());
            Console.WriteLine($"La cantidad de pares del numero {numero} es {c}");
        }
    }
}
