using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415926535;
           double radius = 12.5;
            double area = PI * radius * radius;

            Console.WriteLine("Circlearea = {0}", area);
            Console.ReadLine();



        }

    }
}
