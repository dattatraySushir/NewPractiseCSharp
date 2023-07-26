using NewPractise.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPractise
{
   public class MainMethodProgram
    {
        public static void Main(string[] args)
        {
            Hello h = new Hello();
            h.ExtractMethod();
        }
    }
}
