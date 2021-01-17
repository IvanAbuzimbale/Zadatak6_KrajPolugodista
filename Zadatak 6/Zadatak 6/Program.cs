using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int zbroj = 0;
            Console.Write("Unesite željeni broj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                zbroj = zbroj + i;
            }
            Console.WriteLine("Zbroj prvih n brojeva je " + zbroj);
            Console.ReadKey();
        }
    }
}
