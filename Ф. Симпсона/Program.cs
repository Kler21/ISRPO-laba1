using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ф.Симпсона
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static double F(double x)
        {
            return Math.Sqrt(3 + Math.Cos(x));
        }

        static void Main(string[] args)
        {
            double A = 0;
            double B = Math.PI;


            double.TryParse(Console.ReadLine(), out double E);
            

            double S = 0;
            double S1 = 90000000000000;
            double n = 4;
            double h;

            do
            {
                S = S1;
                S1 = 0;
                h = (B - A) / n;

                for (int i = 0; i < n; i++)
                {
                    double x = A + h * i;

                    if (i == 0 || i == n - 1)
                    {
                        S1 += F(x);
                    }
                    else if (i % 2 != 0)
                    {
                        S1 += F(x) * 4;
                    }
                    else
                    {
                        S1 += F(x) * 2;
                    }
                }

                S1 *= h / 3d;
                n *= 2;

            } while (Math.Abs(S - S1) > E);

            Console.WriteLine("{0:f4}", S1);
            Console.ReadKey();
        }
    }

}

