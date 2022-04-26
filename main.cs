// Created by: Zaida Hammel
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
        Console.WriteLine("Pick a number from 1-6 and guess what the randomized number is.");
        if (guess != returnNumber)
        {
            guess = Convert.ToInt32(Console.Read());
            Console.WriteLine("That's too bad, you got it wrong! Try again. The answer was " + returnNumber + ".");
            Console.ReadLine();
        }
        if (guess == returnNumber)
        {
            Console.WriteLine("You guessed it! It was " + returnNumber + ".");
            Console.ReadLine();
        }
    }
}