using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPractise.DummyFramework
{
    public interface Tejas
    {
         void Abhishek();
        void Vishwajeet();
        void Prasanna();
        const string a = "datta";
        static string b = "Datta";
    }
    public abstract class Dattatray : Tejas
    {
       public string book = "Abstract book";
        public Dattatray() 
        {
            Console.WriteLine("This is dattatray constructor");
        }
        public void Abhishek()
        {
            Console.WriteLine("The abhishek method is overriding in the abstract class and implemented ");
        }
       public abstract void Vishwajeet();
        public virtual void Prasanna()
        {
            Console.WriteLine("This method is kept as virtual for further implementation");
        }
    }
    public class Veena : Dattatray
    {

        public sealed override void Vishwajeet()
        {
            Console.WriteLine("The method is sealed and overridedn in the veena class");
        }
        public override void Prasanna()
        {
            Console.WriteLine("This prasanna method is override in the veena class");
        }

    }
    public class Varun : Tejas 
    {
        public Varun() :this("datta")
        {
            Console.WriteLine("Varun class constructor without parameter is invoked");
        }
        public Varun(String name) 
        {
            Console.WriteLine("This varun class constructor with parameters is invoked");
        }
        public void Abhishek()
        {
            Console.WriteLine("This abhishek method is re-implementd in the varun class ");
        }
        public void Vishwajeet()
        {
            Console.WriteLine("This vishwajeet method is re-implemented in the varun class");
        }
        public void Prasanna()
        {
            Console.WriteLine("This prasanna method is re-implemented in the varun class");
        }

    }
    public class Yusuf : Varun
    {
        public Yusuf() : this("datta")
        {
            Console.WriteLine("The Yusuf class constructor without parameter is get invoked");
        }
        public Yusuf(String name) : base() 
        {
            Console.WriteLine("The yusuf class constructor with parameter is get invoked");
        }
    }
    public class Sushma
    {
        public static void Main(String[] args)
        {
            Tejas s = new Yusuf(); 
            s.Abhishek();
            s.Vishwajeet();
            s.Prasanna();
            Console.WriteLine(Tejas.a);
            Console.WriteLine(Tejas.b);


            Tejas ve = new Veena();
            ve.Abhishek();
            ve.Vishwajeet();
            ve.Prasanna();
            


        }
    }


}
