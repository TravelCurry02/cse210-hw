using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int user_Num = -1;       
     

       while (user_Num != 0){
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string user_input = Console.ReadLine();
        user_Num = int.Parse(user_input);

        if (user_Num != 0){
            numbers.Add(user_Num);
        }
       }

       int sum = 0;
       foreach (int i in numbers){
        sum += i;
       }
       Console.WriteLine($"The sum is: {sum}");

       float average = ((float)sum) / numbers.Count;
       Console.WriteLine($"The average is: {average}");

       int max = numbers[0];

       foreach (int i in numbers){
        if (i > max){
            max = i;
        }
       }

       Console.WriteLine($"The max is: {max}");

    }
}