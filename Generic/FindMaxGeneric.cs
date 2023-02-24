using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class FindMaxGeneric<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public T[] value;
        public FindMaxGeneric(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public FindMaxGeneric(T[] value)
        {
            this.value = value;
        }
        public T GenericMaxNumber(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine("The maximum value is: " + firstValue);
                return firstValue;
            }
            else if (secondValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine("The maximum value is: " + secondValue);
                return secondValue;
            }
            else
            {
                Console.WriteLine("The maximum value is: " + thirdValue);
                return thirdValue;
            }
        }
        public void TestMaximum()
        {
            T result = GenericMaxNumber(firstValue, secondValue, thirdValue);
            Console.WriteLine("Maximum value is: " + result);
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            //Console.WriteLine("The max value is: " + max);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("The max value is: " + max);
        }
    }
}