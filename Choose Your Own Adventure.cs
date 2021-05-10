using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.WriteLine("Type YES or NO: ");
      string noiseChoice = Console.ReadLine();
      string bigNoise = noiseChoice.ToUpper();

      if (bigNoise == "NO")
      {
        Console.WriteLine("Your weakness was your flaw. The monster has killed you. THE END.");
      }
      else if (bigNoise == "YES")
      {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
      

      Console.WriteLine("Type OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine();
      string bigDoor = doorChoice.ToUpper();

      if (bigDoor == "KNOCK")
      {
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
        Console.WriteLine("Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
        Console.WriteLine("Type your answer: ");
        string riddleAnswer = Console.ReadLine();
        riddleAnswer = riddleAnswer.ToUpper();
        
          if (riddleAnswer == "NOTHING")
          {
            Console.WriteLine("The door opens and NOTHING is there");
            Console.WriteLine("You turn off the light and run back to your room and lock the door.");
            Console.WriteLine("THE END.");
          }
          else
          {
            Console.WriteLine("Your answer is WRONG. The house grows cold and dark.");
            Console.WriteLine("You now find yourself locked in the same room with the monster.");
            Console.WriteLine("THE END.");
          }
      }
      else if (bigDoor == "OPEN")
      {
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");
        Console.WriteLine("Try a key. Enter a number (1-3): ");
        string keyChoice = Console.ReadLine();
        keyChoice = keyChoice.ToUpper();

        switch (keyChoice)
        {
          case "1":
            Console.WriteLine("You choose the first key. Lucky choice!");
            Console.WriteLine("The door opens and NOTHING is there. Strange...");
            Console.WriteLine("THE END.");
            break;

          case "2":
            Console.WriteLine("You chose the second key. The door doesn't open.");
            Console.WriteLine("THE END.");
            break;

          case "3":
            Console.WriteLine("You chose the third key. The door opens to reveal a completely empty room.");
            Console.WriteLine("A chill runs up your spine as the light begins to flicker.");
            Console.WriteLine("THE END.");
            break;
        }
      }
      }
     
    }
  }
}



