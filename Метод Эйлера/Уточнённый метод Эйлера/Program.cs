using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Уточнённый_метод_Эйлера
{
    internal class Program
    {
        static double F(double x, double y)
        {
            double f = (3 - y) / x;
            return f;
        }
        static void Main(string[] args)
        {
            double x0 = 1;//начальные точки
            double y0 = 0;
            double h = 0.1;//шаг
            double b = 2;//точка остановы
            double x11 = 0;//половинки
            double y11 = 0;
          

            double x = 1;//след
            double y = 0;

            x11 = x0 + h / 2;   y11 = y0 + F(x0,y0)*(h/2);
            
            

           for (int i = 0; i <10; i++)
            {
                y+=F(x11,y11)*h;
                x += h;
              
                Console.WriteLine("X= " + x + " " + "Y= " + y);
            }

               
            
           

            


            Console.ReadKey();
        }
    }
}
