using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class NGC
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(90);
            arrayList.Add(1);
            arrayList.Sort();
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        public void StackHandling()
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push("AA");
            st.Push(1.2);
            st.Push(66);
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            st.Pop();

            foreach(var item in st)
            {
                Console.WriteLine(item);
               
            }
            Console.WriteLine("POp  :"+st.Pop());
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
           // Console.WriteLine(st.Peek);
        }
        public void QueueHandling()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("AA");
            q.Enqueue(q.Count);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            q.Dequeue();
            Console.WriteLine("After Dequeue :");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(q.Peek());


        }
        public void HashTableHandling()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 10);
            ht.Add(2, 20);  
            ht.Add(3, 30);
            ht.Add(4, "AAA");
            ht.Add(5, 2.9);
            foreach(var item in ht)
            { Console.WriteLine(item); }
            ht.Remove(1);
            ht.Remove(3);
            foreach (var item in ht)
            { Console.WriteLine(item); }
            foreach (var item in ht.Keys)
            { Console.WriteLine(item); }
            foreach (var item in ht.Values)
            { Console.WriteLine(item); }

        }
        public void SortedListHandling()
        {
            SortedList SL=new SortedList();
            SL.Add(1, 10);
            SL.Add(2, 20);
            SL.Add(5, 30);
            SL.Add(3,1);
            SL.Add(8, -99);
            SL.Add(4, "AA");
            foreach(var item in SL)
            {
                Console.WriteLine(item);
            }
        }
    }
}
