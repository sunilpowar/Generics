using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Generics<T> where T : IComparable
    {
        public T first, second, third;
        public Generics(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            FindMax();
        }
        public void FindMax()
        {
            if ((first.CompareTo(second) > 0) && (first.CompareTo(third) > 0))
            {
                Console.WriteLine(first + " is greates");
            }
            else if ((second.CompareTo(first) > 0) && (second.CompareTo(third) > 0))
            {
                Console.WriteLine(second + " is greatest");
            }
            else if ((third.CompareTo(second) > 0) && (third.CompareTo(first) > 0))
            {
                Console.WriteLine(third + " is greatest");
            }
            else
            {
                Console.WriteLine("All are equal");

            }
        }

    }
}
