using System;
using System.Linq;

namespace Prueba
{
    class Program
    {
		public static void Main()
		{
			string numTarjeta;
			string ageExpiration;

			Console.WriteLine("Ingrese el número de la tarjeta");
			numTarjeta = Console.ReadLine();

			Console.WriteLine("Ingrese los dos últimos digitos del año de expiración:");
			ageExpiration = Console.ReadLine();

			// operadores logicos && || < > <= >= 
			if (string.IsNullOrEmpty(numTarjeta)
				  || string.IsNullOrEmpty(ageExpiration)
				  || ageExpiration.Length != 2
				  || numTarjeta.Length != 16
				  || !IsNumeric(numTarjeta)
				  || !IsNumeric(ageExpiration)
				  || ValidationAge(ageExpiration)
				  || !ValidationTarget(numTarjeta)
			   )
			{
				Console.WriteLine("false");

			}
			else
			{

				Console.WriteLine("true");

			}

		}

        private static bool ValidationTarget(string numTarjeta)
        {
            if (numTarjeta.StartsWith("4") 
				|| numTarjeta.StartsWith("13")
				|| numTarjeta.StartsWith("16")
				)
            {
				return true;

            }
            else
            {
				return false;
            }
        }

        public static bool IsNumeric(string value)
		{
			return value.All(char.IsNumber);
		}

		public static bool EsNulo(string dato)
		{
			if (string.IsNullOrEmpty(dato))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool ValidationAge(string dato)
		{
			int age = Convert.ToInt16(dato);
			if (age < 7 || age > 20)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool ActualAge(string age)
		{
			DateTime d = DateTime.Now;
			string ageNow = d.ToString("yy");

			int actualYear = Convert.ToUInt16(ageNow);
			int expirationYear = Convert.ToUInt16(age);

			return expirationYear < actualYear;
		}


	}
}
