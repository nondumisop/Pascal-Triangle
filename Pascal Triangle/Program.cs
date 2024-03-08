using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows for Pascal Triangle:");
            int numRows = int.Parse(Console.ReadLine());

            PrintPascalTriangle(numRows);
        }

        static void PrintPascalTriangle(int numRows)
        {
            for (int i = 0; i < numRows; i++)
            {
                // Print spaces before the numbers
                for (int j = 0; j < numRows - i - 1; j++)
                {
                    Console.Write("   ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{CalculateBinomialCoefficient(i, j),4}");
                }

                Console.WriteLine();
            }
        }

        static int CalculateBinomialCoefficient(int n, int k)
        {
            if (k == 0 || k == n)
            {
                return 1;
            }
            else
            {
                return CalculateBinomialCoefficient(n - 1, k - 1) + CalculateBinomialCoefficient(n - 1, k);
            }
        }
    }
}