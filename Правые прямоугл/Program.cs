using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Правые_прямоугл
{
    internal class Program
    {
        static double F(double x)
        {
            double f = Math.Sqrt(3 + Math.Cos(x));
            return f;
        }
        static void Main(string[] args)
        {
            double A = 0;

            double B = Math.PI;

            double E = double.Parse(Console.ReadLine());


            double S = 0;
            double S1 = 90000000000;
            double n = 4;
            double h;
        
            int N = 0;
        R:
            if (Math.Abs(S - S1) > E)
            {
                N++;
                n *= 2;
                S = S1;
                S1 = 0;
                h = (double)(B - A) / n;



                for (int i = 1; i <= n; i++)
                {
                    double x = 0;
                    x = A + h * i;
                    S1 += F(x);
                }

                S1 *= h;
                goto R;
            }
            else
            {
                Console.WriteLine("{0:f4}", S1);
                
            }
            Console.ReadKey();
        }
    }
}

