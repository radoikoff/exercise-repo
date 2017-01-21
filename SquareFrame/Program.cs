using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = "+ ";
            for (int i = 1; i <= n-2; i++)
            {
                line += "- ";
            }
            line += "+";
            //Console.WriteLine(line);
            string line2 = "| ";
            for (int i = 1; i <= n - 2; i++)
            {
                line2 += "- ";
            }
            line2 += "|";
            //Console.WriteLine(line);


                Console.WriteLine(line);
                for (int j = 0; j < n-2; j++)
                {
                    Console.WriteLine(line2);
                }
                Console.WriteLine(line);


        }
    }
}
