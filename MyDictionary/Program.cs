using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private readonly IDictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

        private ICollection<TKey> keys;
        private ICollection<TValue> values;

        public TValue this[TKey key] 
        {
            get 
            { 
                return dictionary[key]; 
            }
            set
            {
                dictionary[key] = value;
            }
        }

        public ICollection<TKey> Keys
        {
            get
            {
                return keys;
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                return values;
            }
        }

        public int Count
        {
            get
            {
                return dictionary.Count;
            }
        }     

        public bool IsReadOnly
        {
            get
            {
                return dictionary.IsReadOnly;
            }
        }
        
        public void Add(TKey key, TValue value)
        {
            dictionary.Add(key, value);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            dictionary.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            dictionary.Clear();
        }

        public bool ContainsKey(TKey key)
        {
            return dictionary.ContainsKey(key);
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return dictionary.Contains(item);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] arr, int arrIndex)
        {
            dictionary.CopyTo(arr, arrIndex);
        }

        public bool Remove(TKey key)
        {
            return dictionary.Remove(key);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return dictionary.Remove(item);
        }

        public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
        {
            return dictionary.TryGetValue(key, out value);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> mydictionary = new MyDictionary<int, string>();

            mydictionary.Add(1, "Hello!");
            mydictionary.Add(2, "This is the MyDictionary class.");
            mydictionary.Add(3, "Bye!");

            foreach (var pair in mydictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }  
        }
    }
}
