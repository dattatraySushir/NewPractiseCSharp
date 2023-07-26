using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPractise.Collections
{
    public class ListCollections
    {
        public void ListObjectsAdd()
        {
            List<string> li = new List<string>();
            li.Add("Dattatray");
            li.Add("Sushir");
            li.Add("Maharashtra");
            li.Add("Test Yantra");
            li.Add("Banglore");
            li.Add("Hyderabad");
            foreach (string st in li)
            {
                Console.WriteLine(st);
            }
        }

    }
    public class MainExecution
    {


        public static void Main(string[] args)
        {
            ListCollections lc = new ListCollections();
            lc.ListObjectsAdd();
        }


    }
}
