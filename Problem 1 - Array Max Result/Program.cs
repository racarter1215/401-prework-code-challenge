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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test1();
        }
    }
}
