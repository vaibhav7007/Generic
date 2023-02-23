using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class FindMaximum
    {
            public void FindMaxInt(int firstInt, int secondInt, int thirdInt)
            {
                if (firstInt.CompareTo(secondInt) > 0 && firstInt.CompareTo(thirdInt) > 0)
                {
                    Console.WriteLine("The {0} is greatest of all number", firstInt);
                }
                else if (secondInt.CompareTo(thirdInt) > 0)
                {
                    Console.WriteLine("The {0} is greatest of all number", secondInt);
                }
                else
                {
                    Console.WriteLine("The {0} is gretest of all number", thirdInt);
                }
            }
        }
    }

