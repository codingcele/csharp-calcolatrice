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
                Console.WriteLine(-num);
                return -num;
            }
            else
            {
                Console.WriteLine(num);
                return num;
            }
        }
        public static double Abs(double num)
        {
            if (num < 0)
            {
                Console.WriteLine(-num);
                return -num;
            }
            else
            {
                Console.WriteLine(num);
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
    }

}