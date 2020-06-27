using System;

namespace MetanitLesson2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter deposit amount: ");
            decimal deposit = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the quantity of months: ");
            int months = int.Parse(Console.ReadLine());
            int i = 0;
            while(i < months)
            {
                deposit += deposit * 0.07M;
                i++;
            }
            Console.WriteLine($"The final amount is {deposit}");

            Console.ReadLine();
        }
    }
}
