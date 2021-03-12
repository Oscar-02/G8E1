using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace G8E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0, edad = 0;
            year = Year();
            edad = Edad(year);
            Console.WriteLine("La edad actual (sin contar meses) de la persona es de " + edad + " años.");
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static int Year()
        { 
            int year = 0;
            bool error = true;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese el año de nacimiento...");
                    year = int.Parse(Console.ReadLine());
                    error = false;
                }
                catch (FormatException)
                {
                    error = true;
                    Console.WriteLine("Error de formato. Ingrese un valor numerico valido.");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
            }
            while (error ==  true);
            return year;
        }

        static int Edad(int year)
        {
            int edad = 0;
            int today_year = DateTime.Today.Year;
            if (year > today_year)
            {
                Console.WriteLine("Error. El programa no puede procesar el dato ingresado ya que el año");
                Console.WriteLine("ingresado es mayor al año actual (" + today_year + ").");
                Console.Write("La aplicacion se cerrara");
                for (int i = 0; i < 4; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write('.');
                }
                Environment.Exit(0);
            }
            else
            {
                edad = today_year - year;
            }
            return edad;
        }
    }
}
