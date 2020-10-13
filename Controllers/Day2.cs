using System;
using System.Collections.Generic;
using CSharpLogin.Models;

namespace UserController
{
  class Day2 //controller
  {

    public Dictionary<string, User> Users { get; set; }

    public void Login()
    {
      bool valid = false;
      Console.Clear();
      while (!valid)
      {
        Console.WriteLine("Please Login to continue\nUsername:");
        string username = Console.ReadLine();
        Console.WriteLine("Password: ");
        string password = Console.ReadLine();
        //Always check that dictionary has a key before you try to use it, otherwise app crashes
        if (Users.ContainsKey(username) && Users[username].ValidatePassword(password))
        {
          Console.WriteLine("success");
          valid = true;
        }
        else
        {
          Console.WriteLine("fail");
        }
      }
    }
    public void Register(User newUser)
    {
      Users.Add(newUser.Name.ToLower(), newUser);
    }

    public Day2()
    {
      // YOU MUST INSTANTIATE COLLECTION
      Users = new Dictionary<string, User>();
      Users.Add("mark", new User("mark", "iHeartCode"));
      Users.Add("jake", new User("jake", "theBest"));
      Users.Add("d$", new User("d$", "rupees"));
    }
  }
}