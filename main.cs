using System;

class Program {
  public static void Main (string[] args) {
   AskForNumber();
   
  }
  static void AskForNumber()
  {
    Console.WriteLine("Choose a whole number between 1 and 100.");
    string Input = Console.ReadLine();
    Int32 Response;
    if(Int32.TryParse(Input, out Response))
    {
    if (Response >= 1 && Response <=100)
    {
      //per Josh, attempt to do this with less if/else, create empty string which is updated by true statements
        if (Response % 3 == 0 && Response % 2 ==0)
    {
      Console.WriteLine("Fizz Buzz!");
    }
    else if (Response % 3 == 0)
    {
      Console.WriteLine("Fizz!");
    }
    else if (Response % 2 == 0)
    {
      Console.WriteLine("Buzz!");
    }
    else
    {
      Console.WriteLine($"{Response} does not have any funny words.");
    }
    Console.WriteLine("Wanna do it again?");
    Console.WriteLine("Type YES or NO");
    string Choice = Console.ReadLine();
    string CleanChoice = Choice.ToUpper();
    switch (CleanChoice)
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
      else 
    {
      Console.WriteLine("Follow the instructions next time!");
      AskForNumber();
   }
}
}
