using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPractise.Operators
{
    internal class Operators
    {
        public static void Main2()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("The addition of two no. is "+(a+b));
            Console.WriteLine("The subtraction of two no. is "+(b - a));
            Console.WriteLine("The multiplication of the two no is "+(a*b));
            Console.WriteLine("The division of the two no is " + (b / a));
            Console.WriteLine("The Quotient of the two no is " + (b % a));
            Console.WriteLine("The increment to the a is " + a++);
            Console.WriteLine(a);
            Console.WriteLine("the increment to the b is "+b++);
            Console.WriteLine(b);
            Console.WriteLine("The decremenrt to the a " + a--);
            Console.WriteLine(a);
            Console.WriteLine("The decremen to the b "+b--);
            Console.WriteLine(b);
            Console.WriteLine("if Unary operator != "+(a!=b));
            Console.WriteLine("Greater than "+(a>b));
            Console.WriteLine("Less than "+(a<b));
            Console.WriteLine("Greater Than equal to "+(a>=b));
            Console.WriteLine("Less than equal to "+(a<=b));
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("Shift operator >> "+(a>>b));
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("Shift operator << "+(a<<b));
            


            Console.WriteLine("The assignment operator is = " + (a = b));

        }
    }
}
