using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPractise.Programs
{
    internal class Class1

    {
        public static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            //c1.LargestAndSmallestNO();
            //c1.RemoveSpecialCharacter();
            //c1.FibonacciSeries();
            //c1.ReverseArray();
            //c1.LowerToUpper();
        }
        public void LargestAndSmallestNO()
        {
            int[] num = { 12, 343, 3242, 313, 133 };
            int len = num.Length;
            int max = num[0];
            int min = num[0];
            for (int i = 0; i < len; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }

                else if (num[i] < min)
                {
                    min = num[i];
                }

            }
            Console.WriteLine("The minimum number in array is "+min);
            Console.WriteLine("The maximum number in array is " + max);
        }
        public void RemoveSpecialCharacter()
        {
            String str = "j#abd%he!k&m(mh)fg@";
            String str1=str.ToLower();
            for(int i = 0;i < str1.Length;i++)
            {
                char c = str1[i];
               if(c>='a' && c<='z')
                {
                    Console.Write(c);
                }
               else
                {
                    Console.Write(" ");
                }
            }
        }
        public void FibonacciSeries()
        {
            int a = 0;
            int b=1;
            int c;
            for(int i = 0;i<10;i++)
            {
                c = a + b;
                Console.Write(c+" ");
                a = b;
                b = c;
            }
        }
        public void ReverseArray()
        {
            int[] a = { 23, 25, 29, 28, 26, 30, 45 };
            int len=a.Length-1;
            for(int i=len;i>=0;i--)
            {
                Console.Write(a[i]+" ");
            }
        }
        public void LowerToUpper()
        {
            char ch = 'a';
            if(ch>='a' && ch <= 'z')
            {
                char upper = (char)(ch - 32);
                Console.Write(upper);
            }
            else
            {
                char lower= (char)(ch +32);
                Console.Write(lower);
            }
        }


    }
}
