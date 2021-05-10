using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      
      Console.WriteLine("Enter an amount to convert to coins:");
      string totalAsString = Console.ReadLine();
      Console.WriteLine(totalAsString);


      double total = Convert.ToDouble(totalAsString);

      Console.WriteLine($"{total} cents is equal to...");

//define coin values

      int quarterValue = 25;
      int dimeValue = 10;
      int nickelValue = 5;

      double quarters = Math.Floor(total / quarterValue);
      double remainder1 = total % quarterValue;

      double dimes = Math.Floor(remainder1 / dimeValue);
      double remainder2 = remainder1 % dimeValue;

      double nickels = Math.Floor(remainder2 / nickelValue);
      double remainder3 = remainder2 % nickelValue;

      double remainderFinal = Math.Floor(remainder3 % nickelValue);

// Print the Results
      Console.WriteLine($"Quarters: {quarters}");
      Console.WriteLine($"Dimes: {dimes}");
      Console.WriteLine($"Nickels: {nickels}");
      Console.WriteLine($"Pennies: {remainderFinal}");

    }
  }
}
