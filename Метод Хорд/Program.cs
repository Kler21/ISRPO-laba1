using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_Хорд
{
    internal class Program
    {
        static double f(double x)
        {
            return 2 * Math.Sin(x) - Math.Atan(x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите погрешность: ");
            double E = double.Parse(Console.ReadLine());


            double y=f(a);
            double h = (b - a) / 100;
            double ah = a + h;
            double d=f(a+2*h)-2*f(ah)+f(a);

            double x0;
            double c;
            double x1;
            

            if (y*d<0)
            {
                x0 = a;
                c = b;
            }
            else
            {
                x0 = b;
                c = a;
            }

            Z:
            x1= ((x0 * f(c)) - (f(x0) * c)) / (f(c) - f(x0));

            if(Math.Abs(x0-x1)>E)
            {
                x0 = x1;
                goto Z;
            }
            else
            {
                Console.WriteLine(Math.Round(x1,6));
                
            }
            Console.ReadKey();
        }
    }
}
