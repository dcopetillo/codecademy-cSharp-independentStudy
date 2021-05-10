using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "~!@#$%^&*-+";

      Console.WriteLine("Enter a password: ");
      string password = Console.ReadLine();

      int score = 0;

      if (password.Length >= minLength)
      {
        score++;
      }

      if (Tools.Contains(password, uppercase))
      {
        score++;
      }

      if (Tools.Contains(password, lowercase))
      {
        score++;
      }

      if (Tools.Contains(password, digits))

      {
        score++;
      }

      if (Tools.Contains(password, specialChars))
      {
        score++;
      }

 switch (password)
      {
        case "password":
          Console.WriteLine("Unacceptable");
          break;

    
      }

      switch (score)
      {
        case 5:
          Console.WriteLine("Strength: Extremely Strong");
          break;

        case 4:
          Console.WriteLine("Strength: Very Strong");
          break;

        case 3:
          Console.WriteLine("Strength: Strong");
          break;

        case 2:
          Console.WriteLine("Strength: Medium");
          break;

        case 1:
          Console.WriteLine("Strength: Weak");
          break;

        default:
          Console.WriteLine("Password standards not met. Please try again.");
          break;
      }

     





  

    }
  }
}
