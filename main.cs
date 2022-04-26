// Created by: Jaejun Lee
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int returnNumber = random.Next(1, 6);
        int guess = 0;
        Console.WriteLine("Choose a number from 1-6.");
        if (guess != returnNumber)
        {
            guess = Convert.ToInt32(Console.Read());
            Console.WriteLine("The answer was, " + returnNumber + "!" + " good try");
            Console.ReadLine();
        }
        if (guess == returnNumber)
        {
            Console.WriteLine("The answer was, " + returnNumber + "!" + " Great job");
            Console.ReadLine();
        }
    }
}