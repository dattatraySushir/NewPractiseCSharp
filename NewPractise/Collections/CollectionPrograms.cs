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
            //adding elements in the List by using .Add();
            li.Add("Dattatray");
            li.Add("Sushir");
            li.Add("Maharashtra");
            li.Add("Test Yantra");
            li.Add(null);//null values are allowed
            li.Add("Banglore");
            li.Add("Hyderabad");
            //printing the elements using foreach loop
            foreach (string st in li)
            {
                Console.WriteLine(st);
            }
        }

    }
    public class HashsetCollections
    {
        
        public void HashObjectsAdd()
        {
            HashSet<string> hs = new HashSet<string>();
            //adding elements in the hashset by using .Add();
            hs.Add("Microsoft");
            hs.Add(".NET");
            hs.Add("C#");
            hs.Add("Universe");
            hs.Add(".NET");//duplicate are allowed
            hs.Add("Mobile");
            //printing the elements using foreach loop
            foreach(string str in hs)
            {
                Console.WriteLine(str);
            }
        }
    }
    public class SortedSetCollections
    {
        public void SortedObjectsAdd()
        {
            SortedSet<string> ss = new SortedSet<string>();
            //adding elements in the Sortedset by using .Add();
            ss.Add("Bag");
            ss.Add("b");
            ss.Add("Table");
            ss.Add("a");
            ss.Add("u");
            ss.Add("g");
            //printing the elements using foreach loop
            foreach (string data in ss)
            {
                Console.WriteLine(data);
            }

        }
    }
    public class LinkedListCollections
    {
        public void LinkedListObjectsAdd()
        {
            LinkedList<string> ls = new LinkedList<string>();
            //adding elements in the LinkedList by using .AddFirst(); and .AddLast();
           ls.AddFirst("a");
           ls.AddFirst("b");
           ls.AddFirst("school");
           ls.AddFirst("d");
           ls.AddFirst("institution");
           ls.AddFirst("f");
            //printing the elements using foreach loop
            foreach (string data in ls)
            {
                Console.WriteLine(data);
            }

        }
    }
    public class StackCollections
    {
        public void StackObjectsAdd()
        {
            Stack<string> st = new Stack<string>();
            //adding elements in the Stack by using .Push();
            st.Push("a");
            st.Push("b");
            st.Push("e");
            st.Push("f");
            st.Push("g");
            st.Push("c"); 
            st.Push("d");
            st.Push("h");
            foreach (string data in st)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());

        }
    }
    public class QueueCollections
    {
        public void QueueObjectsAdd()
        {
            Queue<string > q = new Queue<string>();
            //adding elements in the Queue by using .Enqueue();
            q.Enqueue("a");
            q.Enqueue("b");
            q.Enqueue("e");
            q.Enqueue("c");
            q.Enqueue("d");
            q.Enqueue("h");
            q.Enqueue("i");
            q.Enqueue("f");
            q.Enqueue("g");
            foreach (string s in q)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());





        }
    }


    public class MainExecution
    {


        public static void Main(string[] args)
        {
           /* ListCollections lc = new ListCollections();
            lc.ListObjectsAdd();
            HashsetCollections hsc = new HashsetCollections();
            hsc.HashObjectsAdd();
            SortedSetCollections sc = new SortedSetCollections();
            sc.SortedObjectsAdd();
           LinkedListCollections ls = new LinkedListCollections();
            ls.LinkedListObjectsAdd();
           StackCollections st = new StackCollections();
            st.StackObjectsAdd();*/
           QueueCollections qs = new QueueCollections();
            qs.QueueObjectsAdd();




        }


    }
}
