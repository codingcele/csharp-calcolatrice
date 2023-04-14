using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{

    public class CalcoliHelper
    {
        public static int Sum(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
            return num1 + num2;
        }
        public static double Sum(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
            return num1 - num2;
        }
        public static double Subtract(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
            return num1 * num2;
        }
        public static double Multiply(double num1, double num2)
        {
            Console.WriteLine(num1 * num2);
            return num1 * num2;
        }
        public static int Abs(int num)
        {
            if (num < 0)
            {
                return -num;
            }
            else
            {
                return num;
            }
        }
        public static double Abs(double num)
        {
            if (num < 0)
            {
                return -num;
            }
            else
            {
                return num;
            }
        }
        public static int Min(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine(777777777);
                return 777777777;
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num1);
                return num1;
            }
            else
            {
                Console.WriteLine(num2);
                return num2;
            }
        }
        public static double Min(double num1, double num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine(777777777);
                return 777777777;
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num1);
                return num1;
            }
            else
            {
                Console.WriteLine(num2);
                return num2;
            }
        }
        public static int Max(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine(777777777);
                return 777777777;
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2);
                return num2;
            }
            else
            {
                Console.WriteLine(num1);
                return num1;
            }
        }
        public static double Max(double num1, double num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine(777777777);
                return 777777777;
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2);
                return num2;
            }
            else
            {
                Console.WriteLine(num1);
                return num1;
            }
        }
        public static double Power(int b, int e)
        {
            if (b == 0 && e == b)
            {
                Console.WriteLine(1);
                return 1;
            }
            else
            {
                double result = 1;
                {
                    for (int i = 0; i < Abs(e); ++i)
                    {
                        if (e < 0)
                            result = result * 1/(double)b;
                        else
                            result = result * (double)b;
                    }
                }
                Console.WriteLine(result);
                return result;
            }
        }
    }

}