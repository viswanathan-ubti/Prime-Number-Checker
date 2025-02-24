using System;
namespace PrimeNumberChecker
{
    class PrimeOrNot
    {   
        // Main Method
        static void Main(string[] args)
        {
            int number;

            // Prompt user to enter a number
            Console.WriteLine("Enter the number to check prime or not: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is prime or not and display the result
            if (isPrime(number))
            {
                Console.WriteLine("Given number {0} is Prime", number);
            }
            else
            {
                Console.WriteLine("Given number {0} is Not Prime", number);
            }
        }

        // Method to check the given number is prime or not
        static bool isPrime(int number)
        {
            // The number less than or equal to 1 are not prime
            if (number <= 1) 
                return false;

            // 2 is the only even prime number    
            if (number == 2) 
                return true;

            // Check the factors from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                // If the factor is found then the number is not prime
                if (number % i == 0) 
                    return false;
            }
            
            // If no factors are found then the given number is prime
            return true;
        }
    }
}