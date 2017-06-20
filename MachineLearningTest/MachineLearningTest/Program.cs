using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearRegression.OneDimensionalLinearRegression clsA = new LinearRegression.OneDimensionalLinearRegression();
            double[] x = { 3, 5.56, 8, 12, 13.3 };
            double[] y = { 5, 8, 9, 11, 12.2 };
            double a;
            double b;
            clsA.SourceXData = x;
            clsA.SourceYData = y;
            clsA.getLinearEquation(out a, out b);
            Console.WriteLine("a={0}", a.ToString());
            Console.WriteLine("b={0}", b.ToString());
            Console.WriteLine("r={0}", clsA.Coefficent.ToString());
            Console.ReadKey();

        }
    }
}
