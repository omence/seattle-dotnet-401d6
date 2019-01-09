using System;

namespace Day02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string FizzBuzz(int num)
        {
            if(num % 3 == 0 && num % 5 == 0)
            {
                return "FizzBuzz";
            } 
            else if(num % 3 == 0)
            {
                return "Fizz";
            }
            else if(num % 5 == 0)
            {
                return "Buzz";
            } 
            return num.ToString();
        }
    }
}
