using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPractise.Polymorphism
{
    public abstract class AbstractClasses
    {
        public abstract void DisplayMethod();

        public virtual void Display1()
        {

        }
    }

    public class NewOne : AbstractClasses
    {
        override
            public void DisplayMethod()
        {
            Console.WriteLine("The method is provided in the sub class");
        }
        override
            public sealed  void  Display1()
        {
            Console.WriteLine("The overriden method from the parent class");
        }
    }

}
