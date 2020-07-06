using System;

namespace Problem_1___Array_Max_Result
{
    class Program
    {
        public static void Test1()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Select 5 Numbers between 1 and 10");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(@"You have selected {0}, {1}, {2}, {3}, and {4}. Please select a number to recieve your score! ", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            int selection = int.Parse(Console.ReadLine());
            int score = selection * Array.FindAll(numbers, x => x == selection).Length;
            Console.Write($"Your score is {score}!");
        }

        public static void Test2()
        {
            Console.WriteLine("Write down a year");
            int year = int.Parse(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine($"The year {year} is a leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"The year {year} is not a leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"The year {year} is a leap year");
            }
            else
            {
                Console.WriteLine($"The year {year} is not a leap year");
            }
        }

        public static void Test3()
        {
            int[] arr = new int[] { 1, 2, 3 };
            if (arr[0] + arr[1] + arr[2] == 6 && arr[0] * arr[1] * arr[2] == 6)
            {
                Console.WriteLine("This is a perfect array");
            }
            else
            {
                Console.WriteLine("This is not a perfect array");
            }
        }

        public static int[] Test4(int[,] numList)
        {
            int[] myArray = new int[numList.GetLength(0)];
            for (int i = 0; i < numList.GetLength(0); i++)
            {
                for (int j = 0; j < numList.GetLength(1); j++)
                {
                    myArray[i] += numList[i, j];
                }
            }
            foreach(int num in myArray)
            {
                Console.WriteLine($"{num}");
            }
            Console.Write("\n");
            return myArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test1();
            Test2();
            Test3();
            Test4();
        }
    }
}
