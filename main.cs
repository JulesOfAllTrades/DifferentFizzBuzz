using System;

class Program
{
    public static void Main(string[] args)
    {
        AskForNumber();
    }
    static void AskForNumber()
    {
        Console.WriteLine("Choose a whole number between 1 and 100.");
        string Input = Console.ReadLine();
        if (int.TryParse(Input, out int response) && response >= 1 && response <= 100)
        {
            string reply = "";
            if (response % 3 == 0 && response % 2 == 0)
            {
                reply = $"FizzBuzz";
            }
            else if (response % 3 == 0)
            {
                reply = "Fizz";
            }
            else if (response % 2 == 0)
            {
                reply = "Buzz";
            }
            else
            {
                reply = $"{response} does not have any funny words.";
            }
            Console.WriteLine(reply);
            Console.WriteLine("Wanna do it again?");
            Console.WriteLine("Type YES or NO");
            string choice = Console.ReadLine();
            string cleanChoice = choice.ToUpper();
            switch (cleanChoice)
            {
                case "YES":
                    AskForNumber();
                    break;
                case "NO":
                    Console.WriteLine("Lame but ok");
                    break;
                default:
                    Console.WriteLine("Not sure what you mean. I'm gonna assume you wanna go again.");
                    AskForNumber();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Follow the instructions next time!");
            AskForNumber();
        }
    }
}