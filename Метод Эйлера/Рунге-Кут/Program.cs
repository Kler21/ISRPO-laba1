using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рунге_Кут
{
    internal class Program
    {
        static double F(double x, double y)
        {
            double f = (3-y)/x;
            return f;
        }
        static void Main(string[] args)
        {
            double a=0.25;
            double x = 1;
            double y = 0;
            double b = 2;
            double h = 0.1;
            double k1 = 0;
            double k2 = 0;
            double delY = 0;

            Z:
            if (x <= b)
            { 
            k1=F(x,y);
            k2=F((x+(h/2*a)), y+((h/2*a)*k1));
            delY = h * ((1 - a) * k1 + (a * k2));

                y += delY;
                x += h;

                Console.WriteLine($"X= {x} " + $"Y={y}");
                goto Z;
            }

            Console.ReadKey();
        }
    }
}
