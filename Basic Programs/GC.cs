using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GC
    {
        public void ListHandling()
        {
            List <int> list = new List <int>();
            list.Add (110);
            list.Add (10);   
            list.Add (201); 
            foreach (int i in list) 
            {
                Console.WriteLine(i+"\n");
            }
            list.Sort ();
            foreach (int i in list)
            {
                Console.WriteLine(i + "\n");
            }
            Console.WriteLine(list.Contains(3));
            
            list.Remove (201);
            Console.WriteLine(list.Contains(201));
            list.RemoveAt (0);

            foreach (int i in list)
            {
                Console.WriteLine(i + "\n");
            }

        }
        public void StackHandling()
        {
            Stack<int> stack = new Stack<int>();    
            stack.Push (10);
             stack.Pop ();  

        }
        public void QueueHandling()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue (10);
            q.Dequeue ();   
        }
        public void DictionaryHandling()
        {
            Dictionary<string,int> keyValuePairs = new Dictionary<string,int> (); 
            keyValuePairs.Add ("Aromal", 2);
            keyValuePairs.Add("Aroo", 1);
            keyValuePairs.Add("Arun", 89);
            foreach( string item in  keyValuePairs.Keys) 
            {
                Console.WriteLine(item);
            }
            foreach(int item  in keyValuePairs.Values)
            {
                Console.WriteLine(item);    
            }
            keyValuePairs.Remove("Aroo");
            foreach (string item in keyValuePairs.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (int item in keyValuePairs.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}
