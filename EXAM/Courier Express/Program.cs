
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            double distance = double.Parse(Console.ReadLine());
            double price = 0;
            //if (type == "standard")
            //{
            if (weight < 1) price = distance * 0.03;
            else if (weight >= 1 && weight <= 10) price = distance * 0.05;
                else if (weight >= 11 && weight <= 40) price = distance * 0.10;
                else if (weight >= 41 && weight <= 90) price = distance * 0.15;
                else if (weight >= 91 && weight <= 150) price = distance * 0.20;
            //}
            if (type == "express")
            {
                if (weight < 1) price = price = price + weight * distance * 0.03 * 80 / 100;
                else if (weight >= 1 && weight <= 10) price = price + weight * distance * 0.05 * 40/100;
                else if (weight >= 11 && weight <= 40) price = price + weight * distance * 0.10 * 5 / 100;
                else if (weight >= 41 && weight <= 90) price = price + weight* distance * 0.15 * 2 / 100;
                else if (weight >= 91 && weight <= 150) price = price + weight * distance * 0.20 * 1 / 100;
            }
            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", weight, price);
        }
    }
}
