using System;
namespace CheckNumberIfPerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the value of the number to check whether that number is a perfect square or not
            int number = 16;

            //Note: Math.Sqrt() returns a double (or int if perfect square)
            Console.WriteLine($"The square root of {number}: {Math.Sqrt(number)}");

            //If we have obtained an int from Sqrt(), then this Math.Floor() should return the same with the Math.Sqrt()
            //Otherwise, it will return round-down value
            Console.WriteLine($"The round-down square root of {number}: {Math.Floor(Math.Sqrt(number))}");

            //Squaring the previous result is an attempt to have the same original number
            //If it resulted to the original number, we can that the original number is indeed a perfect square
            //Otherwise, it is not a perfect squared number
            Console.WriteLine($"The squared round-down square root of {number}: {Math.Pow(Math.Floor(Math.Sqrt(number)), 2)}");
        }
    }
}