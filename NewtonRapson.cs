using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonRapsonMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x_not");
            double x_n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Error");
            double error = Convert.ToDouble(Console.ReadLine());
            double x = 0;
            int i = 1;
            while (i < 4)
            {
                x = x_n- (Eqation(x_n) / InEqation(x_n));
                x_n = x;
                Console.WriteLine("Iteration "+i+", X :"+x);
                i++;
            }
            Console.ReadLine();
        }
        public static double Eqation(double x)
        {
            return (x * x * x) - 20;
        }
        public static double InEqation(double x)
        {
            return 2*(x * x);
        }
    }
}
