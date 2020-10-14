using System;

namespace MorningChallenges
{

  static class Day3
  {
    public static int DoubleInteger(int num)
    {
      // num will be an integer. Double it and return it. (ex 12 => 24)
      return num * 2;
    }
    public static bool IsNumberEven(int num)
    {
      //num will be an integer. Return true if it’s even, and false if it isn’t.
      // return num % 2 == 0
      if (num % 2 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static string GetFileExtension(string str)
    {
      // str will be a string, but it may not have a file extension.
      // return the file extension (with no period) if it has one, otherwise "invalid"

      int lastindex = str.LastIndexOf(".");
      return lastindex == -1 || lastindex == str.Length - 1 ? "invalid" : str.Substring(+1);
    }
    public static string LongestString(string[] arr)
    {
      string longest = arr[0];
      for (int i = 0; i < arr.Length; i++)
      {
        string word = arr[i];
        if (word.Length > longest.Length)
        {
          longest = word;
        }
      }
      return longest;
      // arr will be an array. Return the longest string in the array
    }
    public static int ArraySum(int[] arr)
    {
      //given an array return the sum of all its values
      int sum = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        sum += arr[i];
      }
      return sum;
    }

  }


}
