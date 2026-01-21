using System;
using System.Security.Cryptography;

class Program
{
    
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        bool isGuessed = false;
        


        while (isGuessed == false)
        {
                    Console.WriteLine($"What is the magic number? {magicNumber}");
                    Console.WriteLine("What is your guess?");
                    int playerNumber = int.Parse(Console.ReadLine());
                    
                    if (playerNumber == magicNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        isGuessed = true;
                    }

                    else if (playerNumber < magicNumber)
                    {
                        Console.WriteLine("Guess higher!");
                    }

                    else 
                    {
                        Console.WriteLine("Guess lower!");
                    }
        }
    }
}