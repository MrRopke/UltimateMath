using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    /// <summary>
    /// Ultimate Math Library
    /// </summary>
    public class Math
    {
        /// <summary>
        /// Add double, int or strings with numbers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Add(double x, double y)
        {
            return x + y;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public double Add(string x, string y)
        {
            return Convert.ToDouble(x) + Convert.ToDouble(y);
        }

        /// <summary>
        /// Multiply double or int
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// Substract double, int or strings with numbers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Substract(double x, double y)
        {
            return x - y;
        }

        public int Substract(int x, int y)
        {
            return x - y;
        }

        public double Substract(string x, string y)
        {
            return Convert.ToDouble(x) - Convert.ToDouble(y);
        }
    }
}
