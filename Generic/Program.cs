using Generic;
using System;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to find maximum using generics");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find maximum integer\n2:Find maximum float\n3:Find maximum string\n4:Find maximum using Generic");
            int option = Convert.ToInt32(Console.ReadLine());
            FindMaximum findMaximum = new FindMaximum();
            FindMaxGeneric<int> findMaxInt = new FindMaxGeneric<int>();
            FindMaxGeneric<float> findMaxFloat = new FindMaxGeneric<float>();
            FindMaxGeneric<string> findMaxString = new FindMaxGeneric<string>();
            switch (option)
            {
                case 1:
                    findMaximum.FindMaxInt(12, 36, 46);
                    break;
                case 2:
                    findMaximum.FindMaxFloat(23.25F, 30.45F, 50.10F);
                    break;
                case 3:
                    findMaximum.FindMaxString("Apple", "Banana", "Pear");
                    break;
                case 4:
                    findMaxInt.GenericMaxNumber(12, 25, 30);
                    findMaxFloat.GenericMaxNumber(26.5f, 30.56f, 45.30f);
                    findMaxString.GenericMaxNumber("Apple", "Pear", "Banana");
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}