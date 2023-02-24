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
            Console.WriteLine("1:Find maximum integer\n2:Find maximum float\n3:Find maximum string\n4:Find maximum using Generic\n5:Refactor to find maximum using generic\n6:Find multiple maximum using generic\n7:");
            int option = Convert.ToInt32(Console.ReadLine());
            FindMaximum findMaximum = new FindMaximum();
            FindMaxGeneric<int> findMaxInt = new FindMaxGeneric<int>(12, 25, 30);
            FindMaxGeneric<float> findMaxFloat = new FindMaxGeneric<float>(26.5f, 30.56f, 45.30f);
            FindMaxGeneric<string> findMaxString = new FindMaxGeneric<string>("Apple", "Pear", "Banana");
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
                case 5:
                    findMaxInt.TestMaximum();
                    findMaxFloat.TestMaximum();
                    findMaxString.TestMaximum();
                    break;
                case 6:
                    Console.WriteLine("Enter count of ineteger number");
                    int count = Convert.ToInt32(Console.ReadLine());
                    int[] numInt = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        numInt[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    FindMaxGeneric<int> findIntMax = new FindMaxGeneric<int>(numInt);
                    findIntMax.MaxMethod();

                    Console.WriteLine("Enter count of float number");
                    int count1 = Convert.ToInt32(Console.ReadLine());
                    float[] numFloat = new float[count1];
                    for (int i = 0; i < count; i++)
                    {
                        numFloat[i] = (float)Convert.ToDouble(Console.ReadLine());
                    }
                    FindMaxGeneric<float> findFloatMax = new FindMaxGeneric<float>(numFloat);
                    findFloatMax.MaxMethod();

                    Console.WriteLine("Enter count of string");
                    int count2 = Convert.ToInt32(Console.ReadLine());
                    string[] str = new string[count2];
                    for (int i = 0; i < count; i++)
                    {
                        str[i] = Console.ReadLine();
                    }
                    FindMaxGeneric<string> findStringMax = new FindMaxGeneric<string>(str);
                    findStringMax.MaxMethod();
                    break;
                case 7:
                    Console.WriteLine("Enter count of ineteger number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int[] numInteger = new int[num];
                    for (int i = 0; i < num; i++)
                    {
                        numInteger[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    FindMaxGeneric<int> findIntegerMaximum = new FindMaxGeneric<int>(numInteger);
                    findIntegerMaximum.PrintMaxValue();

                    Console.WriteLine("Enter count of float number");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    float[] numbFloat = new float[num1];
                    for (int i = 0; i < num1; i++)
                    {
                        numbFloat[i] = (float)Convert.ToDouble(Console.ReadLine());
                    }
                    FindMaxGeneric<float> findFloatMaximum = new FindMaxGeneric<float>(numbFloat);
                    findIntegerMaximum.PrintMaxValue();

                    Console.WriteLine("Enter count of string");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    string[] numbString = new string[num2];
                    for (int i = 0; i < num2; i++)
                    {
                        numbString[i] = Console.ReadLine();
                    }
                    FindMaxGeneric<string> findStringMaximum = new FindMaxGeneric<string>(numbString);
                    findStringMaximum.PrintMaxValue();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}