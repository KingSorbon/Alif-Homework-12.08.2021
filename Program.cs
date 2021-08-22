using System;

namespace Alif_Homework_12._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {

            //Homework 12.08.2021
            //Ex 2, a
            int a = 3;
            int b = 8;
            int sume = (a + b) * (b - a - 1) / 2;
            Console.WriteLine($"Сумма между {a} и {b} числями равно:{sume}");

            //Ex 2, b
            int aa = 5;
            int bb = 12;
            int sum = 0;
            for (int ii = aa + 1; ii < bb; ii++)
            {
                if (ii % 2 != 0)
                {
                    sum += ii;
                }
            }
            Console.WriteLine($"Сумма нечетных чисел между {aa} и {bb}  = " + sum);
            Console.ReadKey();

            //Ex 3
            //rectangle
            int height = 5;
            int width = 20;
            for (int jf = 0; jf < height; jf++)
            {
                for (int ie = 0; ie < width; ie++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //triangle
            int heighte = 5;

            for (int ir = 0; ir < heighte; ir++)
            {
                for (int jv = 0; jv <= ir; jv++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            ////another triangle
            int g = 26;
            int z = 2;

            for (int m = 0; m < 8; m++)
            {
                for (int jm = 0; jm < 52; jm++)
                {
                    Console.Write(" ");
                    if (jm == g)
                    {
                        for (int s = 0; s < z; s++)
                            Console.Write("*");
                    }
                }
                g = g - 1;
                z = z + 2;
                Console.WriteLine();
            }

            //Romb
            int i, j, count = 1, number;
            number = 5;
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();


            //задания 4
            int p = int.Parse(Console.ReadLine());
           int price = 1000;
           int k = 0;
           while (price < 1100)
           {
               k++;
               price += (price * p) / 100;
           }
           Console.WriteLine($"Month is:{k} and prise is {price}");
        }
    }
}
