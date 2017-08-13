using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {

        static double f(double x)
        {
            return x * x - 1.3 * Math.Log(x + 0.5) - 2.8 * x + 1.15;
        }

        static double MethodHord(double prev, double cur, double e)
        {
            double next = 0;
            do
            {
                double x = next;
                next = cur - f(cur) * (prev - cur) / (f(prev) - f(cur));
                prev = cur;
                cur = x;
            } while (Math.Abs(next - cur) > e);

            return next;
        }

        static void Main(string[] args)
        {
            double x0 = 2.1;
            double x1 = 2.5;
            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());
            double x = MethodHord(x0, x1, e);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
