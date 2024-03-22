using System.IO;

namespace reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reverse
            int[] reverseTestData = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Demonstration av Reverse:");
            Console.WriteLine("Före: " + string.Join(",", reverseTestData));
            Reverse(reverseTestData);
            Console.WriteLine("Efter: " + string.Join(",", reverseTestData));
            Console.WriteLine();
        }
        public static void Reverse(int[] numbers)
        {
            string[] neworder = new string[numbers.Length];

            for(int i = 0;i < numbers.Length/2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length-1-i];
                numbers[numbers.Length-1-i] = temp;
            }

        }
    }
}