using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGen = new Random();
        int magic_num = randomGen.Next(1, 101);
        int guess = -1;


        while (guess != magic_num){
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magic_num > guess){
            Console.WriteLine("Higer");
            }
            else if (magic_num < guess){
                Console.WriteLine("Lower");
            }
            else {
            Console.WriteLine("You guessed it");
            }

        } 

    }
}