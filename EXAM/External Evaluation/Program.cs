using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double poorMark = 0;
            double satisfactoryMark = 0;
            double goodMark = 0;
            double verygoodMark = 0;
            double excellentMark = 0;
            for (int i = 0; i < n; i++)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark >= 0 && mark < 22.50) poorMark++;
                else if (mark >= 22.50 && mark < 40.50) satisfactoryMark++;
                else if (mark >= 40.50 && mark < 58.50) goodMark++;
                else if (mark >= 58.50 && mark < 76.50) verygoodMark++;
                else if (mark >= 76.50 && mark <= 100.00) excellentMark++;
            }
            Console.WriteLine("{0:f2}% poor marks", poorMark/n*100);
            Console.WriteLine("{0:f2}% satisfactory marks", satisfactoryMark / n * 100);
            Console.WriteLine("{0:f2}% good marks", goodMark / n * 100);
            Console.WriteLine("{0:f2}% very good marks", verygoodMark / n * 100);
            Console.WriteLine("{0:f2}% excellent marks", excellentMark / n * 100);
        }
    }
}
