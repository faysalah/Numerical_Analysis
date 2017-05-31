using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaussian
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] Matrix = new double[3, 4];

            double[,] Temp = new double[3, 4];



            Console.WriteLine("Give input for 3*3 matrix:");

            for (int i = 0; i < 3; i++)
            {
                string firstName = Console.ReadLine();
                string[] inputs = firstName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < 4; j++)
                {
                    Matrix[i, j] = Convert.ToDouble(inputs[j]);
                    //Console.WriteLine(inputs[j]);

                }
            }
            

           // row1_p = (0,0)*(row1)
           //(1,0)*(row1_p)
           //row2 - row1_p


           //  row1_p = (0,0)*(row1)
           // (2,0)*(row1_p)
           // row3 - row1_p

            for (int i = 0; i < 4; i++)
            {
                Temp[1, i] = Matrix[1, i] - ((Matrix[0, i] / Matrix[0, 0]) * Matrix[1, 0]);
                Temp[2, i] = Matrix[2, i] - ((Matrix[0, i] / Matrix[0, 0]) * Matrix[2, 0]);
            }

            if (Temp[1, 1] == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    double swap = Temp[1, i];
                    Temp[1, i] = Temp[2, i];
                    Temp[2, i] = swap;
                }
            }

            for (int i = 1; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Temp[i, j] + "  ");
                }
                Console.WriteLine();
            }

            if (Temp[2, 1] == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Matrix[1, i] = Temp[1, i];
                    Matrix[2, i] = Temp[2, i];
                }
            }
            else
            {
                for (int i = 1; i < 4; i++)
                {
                    Matrix[1, i] = Temp[1, i];//((Temp[1, i] / Temp[1, 1]) * Temp[2, i]);
                    Matrix[2, i] = ((Temp[1, i] / Temp[1, 1]) * Temp[2, i]) - Temp[2, i];
                }
            }

            double a2 = Matrix[2, 3] / Matrix[2, 2];

            double a1 = (Matrix[1, 3] - (a2 * Matrix[1, 2])) / Matrix[1, 1];

            double a0 = (Matrix[0, 3] - (a1 * Matrix[0, 1]) - (a2 * Matrix[0, 2])) / Matrix[0, 0];


            Console.WriteLine("a0 = {0} a1 = {1} , a2 ={2}", Math.Round(a0, 2), Math.Round(a1, 2), Math.Round(a2, 2));




            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}
