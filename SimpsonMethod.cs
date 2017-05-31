//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Gaussian
//{
//    class SimpsonMethod
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("-----Simpson 1/3 method-----");
//            Console.WriteLine("Give upper limit");
//            double xu = int.Parse(Console.ReadLine());
//            Console.WriteLine("Give lower limit");
//            double xl = int.Parse(Console.ReadLine());
//            Console.WriteLine("Give Segment no n");
//            double n = int.Parse(Console.ReadLine());
//            double h = (xu - xl) / n;
//            double even = 0;
//            double odd = 0;
//            double count = xl;

//            for (int i = 1; i < (xu-xl)/h; i++)
//            {
//                if (i%2 == 0)
//                {
//                    count = count + h;
//                    even = func(count) + even;
//                }
//                else
//                {
//                    count = count + h;
//                    odd = func(count) + odd;
//                }
//            }

//            even = 2 * even;
//            odd = 4 * odd ;

//            double result = (h / 3) * (func(xl) + even + odd + func(xu));
            
//            Console.WriteLine("approximate result : " + result);
//            Console.WriteLine("True error : "+(TrueValue() - result));
//            Console.WriteLine("Absolute relative true error : " +(Math.Abs(((TrueValue() - result)/ TrueValue())))*100);

//            Console.ReadKey();
//        }   
//        public static double func(double x)
//        {
//            return Math.Exp(x);
//        } 

//        public static double TrueValue()
//        {
//            return (Math.Exp(3) - Math.Exp(1));
//        }
//    }
//}
