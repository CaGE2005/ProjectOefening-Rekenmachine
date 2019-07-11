using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    class MathLogic
    {
        public double Calculate(double a, double b, char operand)
        {
            double result = 0;

            if (operand == '+')
            {
                result = Add(a, b);
            }

            if(operand == '-')
            {
                result = Subtract(a, b);
            }

            if (operand == '*')
            {
                result = Multiply(a, b);
            }

            if (operand == '/')
            {
                result = Divide(a, b);
            }

            if (operand == 'i')
            {
                result = Inverse(a);
            }

            if (operand == '²')
            {
                result = Power(a);
            }

            if (operand == '%')
            {
                result = Percent(a, b);
            }

            if (operand == '√')
            {
                result = Root(a);
            }

            if (operand == '=')
            {
                result = a;
            }

            return result;


        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Inverse(double a)
        {
            return 1 / a;
        }

        public double Power(double a)
        {
            return Math.Pow(a,2);
        }

        public double Root(double a)
        {
            return Math.Sqrt(a);
        }

        public double Percent(double a, double b)
        {
            return (b / 100) * a;
        }
    }
}
