using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComplexNumber
{
    struct RealNumber
    {
        public double number;

        public RealNumber(double Number)
        {
            number = Number;
        }
        public static RealNumber operator +(RealNumber leftNumber, RealNumber rigthNumber)
        {
            return new RealNumber(leftNumber.number + rigthNumber.number);
        }
        public static RealNumber operator -(RealNumber leftNumber, RealNumber rigthNumber)
        {
            return new RealNumber(leftNumber.number - rigthNumber.number);
        }
        public static RealNumber operator *(RealNumber leftNumber, RealNumber rigthNumber)
        {
            return new RealNumber(leftNumber.number * rigthNumber.number);
        }
        public static RealNumber operator /(RealNumber leftNumber, RealNumber rigthNumber)
        {
            return new RealNumber(leftNumber.number / rigthNumber.number);
        }
        public static bool operator >(RealNumber leftNumber, RealNumber rigthNumber)
        {
            return leftNumber.number > rigthNumber.number;
        }
        public static bool operator <(RealNumber leftNumber, RealNumber rigthNumber)
        {
            return leftNumber.number < rigthNumber.number;
        }
        public void Print()
        {
            Console.Write(number);
        }
        public RealNumber Square()
        {
            return new RealNumber(Math.Pow(this.number, 2));
        }
        public RealNumber Sqrt()
        {
          return new RealNumber(Math.Sqrt(this.number));
        }
    }
}
