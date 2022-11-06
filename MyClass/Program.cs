using System;

namespace MyClass
{
    class MyClass<T>
    {
        public static T FactoryMethod<T>() where T : new()
        {
            return new T();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int>.FactoryMethod<int>();

            Console.ReadKey();
        }
    }
}
