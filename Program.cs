using System;
namespace PrimeNumberChecker
{
    class PrimeOrNot
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number to check prime or not: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (isPrime(number))
            {
                Console.WriteLine("Given number {0} is Prime", number);
            }
            else
            {
                Console.WriteLine("Given number {0} is Not Prime", number);
            }
        }
        static bool isPrime(int number)
        {
            if (number <= 1) 
                return false;
            if (number == 2) 
                return true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) 
                    return false;
            }
            return true;
        }
    }
}