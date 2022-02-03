using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericMax
    {
        public class GenericMaximum<T> where T : IComparable //Where T data type should inherit IComparable interface
        {
            public T[] value;
            public GenericMaximum(T[] value)
            {
                this.value = value;
            }

            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;

            }

            void add(params int[] a)
            {

            }

            public T MaxValue(params T[] values)
            {
                var sorted_values = Sort(values);

                return sorted_values[sorted_values.Length - 1];
            }

            public T MaxMethod()
            {
                var max = MaxValue(this.value);
                return max;
            }

            public void PrintMaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum value is " + max);
            }
        }
}
