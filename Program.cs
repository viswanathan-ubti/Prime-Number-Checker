// Total TimeComplexity: O(sqrt(n))

using System;
namespace PrimeNumberChecker
{
    class PrimeOrNot
    {   
        // Main Method
        static void Main(string[] args)
        {
            int number;

            // Try block to handle exception
            try
            {
                // Prompt for user to enter a number
                String Message = "Enter the number to check prime or not: ";
                number = GetIntInput(Message); // Time Complexity: O(1)

                // Check if the number is prime or not and display the result
                if (isPrime(number)) // Time Complexity: O(sqrt(n))
                {
                    Console.WriteLine("\nGiven number {0} is Prime", number);
                }
                else
                {
                    Console.WriteLine("\nGiven number {0} is Not Prime", number);
                }
            }

            // Catch block to handle exception
            catch (Exception e)
            {
                Console.WriteLine("Error occured: " + e.Message);
            }
            // finally block
            finally
            {
                Console.WriteLine("Operation Completed...");
            }
            
        }

        // Method to check the given number is prime or not
        static bool isPrime(int number)
        {
            // Try block to handle exception
            try
            {
                // The number less than or equal to 1 are not prime
                if (number <= 1) // Time Complexity: O(1)
                    return false;

                // 2 is the only even prime number    
                if (number == 2) // Time Complexity: O(1)
                    return true;

                // Check the factors from 2 to the square root of the number
                for (int i = 2; i <= Math.Sqrt(number); i++) // Time Complexity: O(sqrt(n))
                {
                    // If the factor is found then the number is not prime
                    if (number % i == 0) // Time Complexity: O(1)
                        return false;
                }
                
                // If no factors are found then the given number is prime
                return true;
            }
            // Catch block to handle exception
            catch (Exception e)
            {
                Console.WriteLine("Error occured in isPrime Method: " + e.Message);
                return false;
            }
        }
        // Method to prompt user for integer input with validation
        static int GetIntInput (String Message)
        {
            Console.Write(Message);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Please enter the valid integer to check prime or not: ");
            }
            return number;
        }
    }
}