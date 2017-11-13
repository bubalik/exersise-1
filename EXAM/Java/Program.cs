using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}~ ~ ~", new string(' ', n));
            }
            Console.WriteLine(new string('=', 3 * n + 5));
            for (int i = 0; i < n-3; i++)
            {
                if (i==(n - 2)/2) Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', n - 1));
                Console.WriteLine("|{0}|{1}|", new string('~', 2*n+4), new string(' ', n-1));
                
            }
            Console.WriteLine(new string('=', 3 * n + 5));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/", new string(' ', i),new string('@', 2*n+4-2*i));
            }
            Console.WriteLine(new string('=', 2 * n + 6));
        }
    }
}
