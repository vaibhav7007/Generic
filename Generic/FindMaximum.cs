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
        public string FindMaxString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
            {
                Console.WriteLine("The maximum value is: " + firstString);
                return firstString;
            }
            else if (secondString.CompareTo(thirdString) > 0)
            {
                Console.WriteLine("The maximum value is: " + secondString);
                return secondString;
            }
            else
            {
                Console.WriteLine("The maximum value is: " + thirdString);
                return thirdString;
            }
        }
    }
}