using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double z = 5, y = 3;
            Console.WriteLine("Before z = {0}", z);
            z /= 14 - 4 * y;
            Console.WriteLine("After z = {0}", z);
            Console.ReadLine();
        }
    }
}