// Created by: Jaejun Lee
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int guess = 0;
        int randomNumber;

        System.Random random = new System.Random();
        randomNumber = random.Next(1, 6);
    
        // input
        Console.WriteLine("Choose a number from 1-6.");
      
       // process
        if (guess != randomNumber)
        {
            guess = Convert.ToInt32(Console.Read());
            Console.WriteLine("The answer was, " + randomNumber + "!");
        }
      
        if (guess == randomNumber)
        {
            Console.WriteLine("The answer was, " + randomNumber + "!");
        }
    }
}
