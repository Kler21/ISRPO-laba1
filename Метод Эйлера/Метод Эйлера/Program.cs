using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_Эйлера
{
    internal class Program
    {
        static double F(double x, double y)
        {
            double f=(3-y)/x;
            return  f;
        }
        static void Main(string[] args)
        {
            double x = 1;//начальные точки
            double y = 0;
            double h= 0.1;//шаг
            double b = 2;//точка остановы

            Z:
            if(x<=b)
            {
                y += F(x, y) * h;
                x += h;
                Console.WriteLine($"X= {x} " + $"Y={y}");
                goto Z;
            }
            Console.ReadKey();
        }

    }
}
