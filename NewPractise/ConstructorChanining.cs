using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPractise
{
    public class ConstructorChanining
    {
        public ConstructorChanining()
        {
            Console.WriteLine("Parent class constructor without parmeters is invoked");
        }
        public ConstructorChanining(string name) :this() 
        {
            Console.WriteLine("Constructor with parameter of parent class is invoked ");
        }
    }
    public class Inheritted : ConstructorChanining
    {
        public Inheritted() : this("datta")
        {
            Console.WriteLine("The child class constructor get invoked");
        }
        public Inheritted(string name) :base("datta")
        {
            Console.WriteLine("The child class constructor with parameters invoked");
                
        }
    }
}
