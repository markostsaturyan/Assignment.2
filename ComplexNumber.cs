using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComplexNumber
{
    class ComplexNumber
    {
        public RealNumber rePart;
        public RealNumber imPart;


        public ComplexNumber()
        {
            rePart = new RealNumber();
            imPart = new RealNumber();
        }
        public ComplexNumber(double reP,double imP)
        {
            this.rePart.number = reP;
            this.imPart.number = imP;
        }
        public ComplexNumber(RealNumber reP,RealNumber imP)
        {
            this.rePart = reP;
            this.imPart = imP;
        }
        //overload mathematics operators for comlex numbers
        public static ComplexNumber operator +(ComplexNumber leftNumber,ComplexNumber rightNumber)
        {
            //(a + ib) + (c + id) = (a + c) + (b + d)i
            return new ComplexNumber(leftNumber.rePart+rightNumber.rePart,leftNumber.imPart+rightNumber.imPart);
        }
        public static ComplexNumber operator -(ComplexNumber leftNumber, ComplexNumber rightNumber)
        {
            ////(a + ib) - (c + id) = (a - c) + (b - d)i
            return new ComplexNumber(leftNumber.rePart - rightNumber.rePart, leftNumber.imPart - rightNumber.imPart);
        }
        public static ComplexNumber operator *(ComplexNumber leftNumber, ComplexNumber rightNumber)
        {
            //(a + ib) * (c + id) = (ac - bd) + (ad + cb)i
            return new ComplexNumber(leftNumber.rePart * rightNumber.rePart - leftNumber.imPart * rightNumber.imPart, leftNumber.rePart * rightNumber.imPart + leftNumber.imPart * rightNumber.rePart);
        }
        public static ComplexNumber operator /(ComplexNumber leftNumber, ComplexNumber rightNumber)
        {
            //(a + bi) / (c + di) = (a + bi) / (c + di) * (c - di) / (c - di) = (a + bi) * (c - di) / (c^2 + d^2)

            ComplexNumber helper = new ComplexNumber(rightNumber.rePart.number, -rightNumber.imPart.number);
            RealNumber real = (helper * rightNumber).rePart;
            helper = helper * leftNumber;
            helper.rePart = helper.rePart / real;
            helper.imPart = helper.imPart / real;
            return helper;
        }
        public RealNumber Absolute()
        {
            // |a+bi|=sqrt(a^2 + b^2)

            RealNumber retNumber;
            retNumber = this.rePart.Square() + this.imPart.Square(); 
            retNumber=retNumber.Sqrt();                                                    
            return retNumber;
        }
        public RealNumber Argument()
        {
            return new RealNumber(Math.Atan2(imPart.number, rePart.number));
        }
        public void Print()
        {
            rePart.Print();
            if(imPart < new RealNumber())
            {
                imPart.Print(); //imaginary negative 
            }
            else
            {
                Console.Write("+");
                imPart.Print();
            }
            Console.Write("i");

        }

    }
}
