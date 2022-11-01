using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyList
{
    internal class MyList<T> : IList<T>
    {
        private readonly IList<T> list = new List<T>();

        public T this[int index] 
        {
            get 
            { 
               return list[index]; 
            }
            set
            {
                list[index] = value;
            } 
        }

        public int Count 
        {
            get 
            { 
                return list.Count; 
            }
        }

        public bool IsReadOnly 
        {
            get 
            { 
                return list.IsReadOnly; 
            }
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

    internal static class ExtensionMethod
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>() {23,15,90,46};
            
            mylist.Add(58);
            mylist.Add(100);

            Console.WriteLine("My List:");
            foreach (int item in mylist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"The index of the first element = {mylist.IndexOf(23)}");
            Console.WriteLine($"Total number of items = {mylist.Count}");
            Console.WriteLine();           

            int[] myarray = ExtensionMethod.GetArray(mylist);

            Console.WriteLine("Elements of the array returned by the GetArray method:");

            foreach (int item in myarray)
            {
                Console.WriteLine(item);
            }             
        }
    }
}
