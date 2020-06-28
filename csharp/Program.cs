using System.Collections.Generic;
using System;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (uint n = 1; n < 100000; n++)
            {
                Stack<uint> arr = new Stack<uint>();
                uint temp = n;
                for (uint i = 2; i < Math.Floor(Math.Sqrt((double)n)) + 1; i++)
                    while (temp % i == 0)
                    {
                        arr.Push(i);
                        temp /= i;
                    }
                if (temp != 1) arr.Push(temp);
                if (arr.Count == 0) arr.Push(n);
            }
        }
    }
}
