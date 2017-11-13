using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            double placeLenth = double.Parse(Console.ReadLine());
            double placeWidth = double.Parse(Console.ReadLine());
            double Net = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double wiight = double.Parse(Console.ReadLine());
            double perimeter = 0;
            double area = 0;
            perimeter = 2*placeWidth +2* placeLenth;
            price = perimeter * price;
            area = perimeter * Net * wiight;
            Console.WriteLine(perimeter);
            Console.WriteLine("{0:f2}", price);
            Console.WriteLine("{0:f3}", area);

        }
    }
}
