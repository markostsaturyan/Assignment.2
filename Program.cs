using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComplexNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            ComplexNumber a = new ComplexNumber(new RealNumber(x),new RealNumber(y));

            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            ComplexNumber b = new ComplexNumber(new RealNumber(x), new RealNumber(y));

            ComplexNumber c;

            c = a + b;
            c.Print();
            Console.WriteLine("\n");

            c = a - b;
            c.Print();
            Console.WriteLine("\n");

            c = a * b;
            c.Print();
            Console.WriteLine("\n");

            c = a / b;
            c.Print();
            Console.WriteLine("\n");

            a.Absolute().Print();
            Console.WriteLine("\n");

            b.Absolute().Print();
            Console.WriteLine("\n");

            a.Argument().Print();
            Console.WriteLine("\n");

            b.Argument().Print();

            Console.Read();

        }
    }
}
