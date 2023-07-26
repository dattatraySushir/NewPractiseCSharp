using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPractise.Encapsulation
{
    public class Baseclass
    {
        private string a = "";
        public string B
        {
            get { return a; }
            set { a = value; }
        }
        public string Display { get; set; }
    }
    public class TestClass : Baseclass
    {
        public void M1()
        {
            Console.WriteLine(B);
            Display = "veena jagtap";
            Console.WriteLine(Display);
            Console.WriteLine("================");
            Console.WriteLine(Display);
            Display = "Tejas kumar";
            Console.WriteLine(Display);
        }
        public static void M2()
        {
            TestClass tc = new TestClass();
            tc.M1();
        }
    }
    public abstract class UseAbstraction
    {
        public abstract void Learn();
        public virtual void M2()
        {
            Console.WriteLine("This is the virtual method form the abstract class");
        }

    }
    public class UsePolymorphism : UseAbstraction
    {
        public void Display()
        {
            Display("datta");
            Console.WriteLine("This is first display method without parameters");
        }
        public static void Display(string name)
        {
            TestClass.M2();
            string d = name;
            Console.WriteLine("This method is parameterised and the value is " + d);
        }

        public override void Learn()
        {
            Display();
            Console.WriteLine("This method is overriden from the Abstraction Class");
        }

        public override void M2()
        {
            Learn();
            Console.WriteLine("The virtual method from the abstraction is completed in the  polymorphism class");
        }

    }
    public interface IInterclass
    {
        const string a = "c-sharp";
        static string b = "c-language";
    }
    public class Hello : UsePolymorphism,IInterclass
    {
        public void ExtractMethod()
        {
            M2();
            Console.WriteLine(IInterclass.a);
            Console.WriteLine(IInterclass.b);
            UsePolymorphism up = new UsePolymorphism();
            up.M2();

        }
        public override sealed void M2()
        {
            Console.WriteLine("This method is overriden 2nd time in the hello class");
        }
    }
}
    
    





