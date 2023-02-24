using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class FindMaxGeneric<T> where T : IComparable
    {
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
    }
}