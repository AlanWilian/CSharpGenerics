using System;

namespace Generics
{
    // where T : IComparable 
    // where T : Product -> children/sub class
    // where T : struct -> value type
    // where T : class -> reference type
    // where T : new() -> obj default constructor
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}