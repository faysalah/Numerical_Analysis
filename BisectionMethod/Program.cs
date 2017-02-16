using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x_lower");
            double x_lower = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x_upper");
            double x_upper = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Error");
            double error_lim = Convert.ToDouble(Console.ReadLine());

            double root,old_root=0,error=error_lim+1;
            if (Eqation(x_lower) * Eqation(x_upper) < 0) {
                int i = 1;
                while (error > error_lim)
                {
                    root = (x_lower + x_upper) / 2;
                    Console.WriteLine("-------------itreration "+i+"-------------------");
                    Console.WriteLine("root:"+root);
                    
                    if (Eqation(x_lower) * Eqation(root) > 0)
                    {
                        Console.WriteLine(Eqation(x_lower)+" * "+Eqation(root)+" > 0");
                        
                        x_lower = root;
                    }
                    else
                    {
                        Console.WriteLine(Eqation(x_lower) + " * " + Eqation(root) + " < 0");

                        x_upper = root;
                    }

                    if (i > 1)
                    {
                    error = Math.Abs((root - old_root) / root) * 100;
                        Console.WriteLine("error:" + error + "%");
                    }

                    Console.WriteLine("lower limit:"+x_lower+"\nupper limit:"+x_upper);

                    old_root = root;
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No root");
            }
            Console.ReadLine();
        }

        public static double Eqation(double x)
        {
            return (x * x * x) - 20;
        }
    }
}
