using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalcoliHelper.Sum(1,3);
            CalcoliHelper.Sum(1.15, 3.6);

            CalcoliHelper.Subtract(1, 3);
            CalcoliHelper.Subtract(1.15, 3.6);

            CalcoliHelper.Multiply(1, 3);
            CalcoliHelper.Multiply(1.15, 3.6);

            CalcoliHelper.Abs(3);
            CalcoliHelper.Abs(-2);
            CalcoliHelper.Abs(1.15);
            CalcoliHelper.Abs(-3.15);

            CalcoliHelper.Min(1, 3);
            CalcoliHelper.Min(5, 2);
            CalcoliHelper.Min(3.6, 1.15);
            CalcoliHelper.Min(2.8, 6.7);

            CalcoliHelper.Max(1, 3);
            CalcoliHelper.Max(5, 2);
            CalcoliHelper.Max(3.6, 1.15);
            CalcoliHelper.Max(2.8, 6.7);
        }
    }
}