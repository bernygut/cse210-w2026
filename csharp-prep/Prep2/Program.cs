using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        int percentage;
        bool pass;

        Console.WriteLine("What was your grade percentage?");
        percentage = int.Parse(Console.ReadLine());

        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >= 80)
        {
            letter = "B";
        }

        else if (percentage >= 70)
        {
            letter = "C";
        }  

        else if (percentage >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        } 

        if (percentage >= 70)
        {
           Console.WriteLine($"Your letter grade is {letter}. You passed!"); 
        }

        else
        {
            Console.WriteLine($"Your letter grade is {letter}. You did not pass!");
        }
        

    }
}