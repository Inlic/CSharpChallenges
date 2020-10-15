using System;

namespace MorningChallengestwo
{
  class Day4
  {


    public void Run()
    {
      bool running = true;
      Console.Clear();
      while (running)
      {
        Console.WriteLine("Would you like to play a game of number guessing? Choose yes or quit.");
        string input = Console.ReadLine().ToLower();
        switch (input)
        {
          case "yes":
            NumberGame();
            break;
          case "quit":
            Console.WriteLine("\nGoodbye\n");
            running = false;
            break;
          default:
            Console.WriteLine("Invalid Input Please try again");
            break;
        }
      }
    }

    public void NumberGame()
    {
      bool playing = true;
      var rnd = new Random();
      int number = rnd.Next(11);
      while (playing)
      {
        Console.WriteLine("I'm thinking of a number between one and ten.  Can you guess what it is?");
        string playerguess = Console.ReadLine();
        if (int.TryParse(playerguess, out int numguess) && numguess > 0 && numguess <= 10)
        {
          if (numguess > number)
          {
            Console.WriteLine("Your Number is too high.");
          }
          else if (numguess < number)
          {
            Console.WriteLine("Your Number is too low");
          }
          else
          {
            Console.WriteLine("That's correct!");
            playing = false;
          }
        }
        else
        {
          Console.WriteLine("Input Invalid, pick a number between 1 and 10");
        }
      }
    }

  }
}