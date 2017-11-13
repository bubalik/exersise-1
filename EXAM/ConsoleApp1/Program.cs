using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatos = double.Parse(Console.ReadLine());
            double casettes = double.Parse(Console.ReadLine());
            double jars = double.Parse(Console.ReadLine());
            double lutenica = 0;
            lutenica = tomatos / 5;
            double numberJars = 0;
            numberJars = lutenica / 0.535;
            double numberCasette = 0;
            numberCasette = numberJars / jars;
            Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(lutenica));
            if (numberCasette > casettes)
            {
                Console.WriteLine("{0} boxes left.", Math.Floor(numberCasette - casettes));
                Console.WriteLine("{0} jars left.", Math.Floor(numberJars - (casettes*jars)));
            }
            else
            {
                Console.WriteLine("{0} more boxes needed.", Math.Floor(casettes-numberCasette));
                Console.WriteLine("{0} more jars needed.", Math.Floor((casettes * jars - numberJars)));
            }

        }
    }
}
