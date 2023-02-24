using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class FindMaximum
    {
        public int FindMaxInt(int firstInt, int secondInt, int thirdInt)
        {
            if (firstInt.CompareTo(secondInt) > 0 && firstInt.CompareTo(thirdInt) > 0)
            {
                return firstInt;
            }
            else if (secondInt.CompareTo(thirdInt) > 0)
            {
                return secondInt;
            }
            else
            {
                return thirdInt;
            }
        }
        public float FindMaxFloat(float firstFloat, float secondFloat, float thirdFloat)
        {
            if (firstFloat.CompareTo(secondFloat) > 0 && firstFloat.CompareTo(thirdFloat) > 0)
            {
                Console.WriteLine("The maximum value is: " + firstFloat);
                return firstFloat;
            }
            else if (secondFloat.CompareTo(thirdFloat) > 0)
            {
                Console.WriteLine("The maximum value is: " + secondFloat);
                return secondFloat;
            }
            else
            {
                Console.WriteLine("The maximum value is: " + thirdFloat);
                return thirdFloat;
            }
        }
    }
}
