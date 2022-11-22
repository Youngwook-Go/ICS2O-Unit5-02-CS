// Created by: Youngwook
// Created on: NOV 2022
//
// This function gets random number and user number
// This function compares random number and user number and answer.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // input
        Random random = new Random();
        int number = random.Next(1, 6);
        int numberInput;
        int input;

        Console.WriteLine(number);
        Console.WriteLine("This program gets and compares random number and user number and answer.\n");
        
        Console.WriteLine("decide the number will be positive or negative.");
        Console.Write("type 0 if you want positive number\ntype 1 if you want negative number\n"); input = Convert.ToInt32(Console.ReadLine());
        
        if (input == 0) {
            Console.WriteLine("The number will be positive\n");
            Console.Write("Enter random number between 1 to 6 --> +"); numberInput = Convert.ToInt32(Console.ReadLine());
            if (numberInput == number)
            {
                Console.WriteLine("Your answer is : +" + numberInput + ".");
                Console.WriteLine("The number was : +" + number + ".");
                Console.WriteLine("You got it!");
            }
            else if (numberInput > 6 || numberInput < 0)
            {
                Console.WriteLine("Input is not a number from 1 to 6!");
            }
            else
            {
                Console.WriteLine("Your answer is : +" + numberInput + ".");
                Console.WriteLine("The number was : +" + number + ".");
                Console.WriteLine("Try again!");
            }
        } else if (input == 1) {
            Console.WriteLine("\nThe number will be negative\n");
            Console.Write("Enter random number between 1 to 6 --> -"); numberInput = Convert.ToInt32(Console.ReadLine());
            if (numberInput == number)
            {
                Console.WriteLine("Your answer is : -" + numberInput + ".");
                Console.WriteLine("The number was : -" + number + ".");
                Console.WriteLine("You got it!");
            }
            else if (numberInput > 6 || numberInput < 0)
            {
                Console.WriteLine("Input is not a number from 1 to 6!");
            }
            else
            {
                Console.WriteLine("Your answer is : -" + numberInput + ".");
                Console.WriteLine("The number was : -" + number + ".");
                Console.WriteLine("Try again!");
            }
        } else {
            Console.WriteLine("\nTHe input was not 0 or 1!");
        }

        Console.WriteLine("\ndone.");
    }
}
