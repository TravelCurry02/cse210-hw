using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percecntage = int.Parse(grade);
        string letter_grade = "";

        if (percecntage >= 90){
            letter_grade = "A";
        }
        else if (percecntage >= 80){
            letter_grade = "B";
        }
        else if (percecntage >= 70){
            letter_grade = "C";
        }
        else if (percecntage >= 60){
            letter_grade = "D";
        }
        else{
            letter_grade = "F";
        }
        Console.WriteLine($"Your grade is: {letter_grade}");

        if (percecntage >= 70){
            Console.WriteLine("You passed");
        }
        else{
            Console.WriteLine("You failed");
        }
    }
}