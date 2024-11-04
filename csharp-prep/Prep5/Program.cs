using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = squareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
      static void DisplayWelcomeMessage(){
         Console.WriteLine("Welcome to the program!");
      }

      static string PromptUserName(){
        Console.Write("What is you name? ");
        string name = Console.ReadLine();

        return name;
      }

      static int PromptUserNumber(){
        Console.Write("What is your favorite number? ");
        int fav_number = int.Parse(Console.ReadLine());
        return fav_number;
      }

      static int squareNumber(int number){
        Console.WriteLine("Enter a number to square it: ");
        int square = number * number;
        return square;
      }
      static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}