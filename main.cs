using System;
using System.Collections.Generic;
// Task # 1
// You have to write a function which takes an array of integers "seq" and an integer "target". There exist two elements of the array whose sum is equal to the target. You can assume that there exists only one solution. You have to return the indices of those elements
// Example 1: [1,9,2,19]  Target = 3, Answer = 0,2

// Example 2: [2,4]  Target = 6, Answer =0,1


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        // List<int> list = new List<int>(){2, 4};
        // var tuple = GetTargetIndices(list, 6);
        // if(tuple == null) return;
        // Console.WriteLine(tuple.Item1 + ", " + tuple.Item2);
        int number = 09; 
        if(IsPalindrome(number))
          Console.WriteLine(number + " is a palindrome");
        else
          Console.WriteLine(number + " is not a palindrome");
    }

    private static Tuple<int, int> GetTargetIndices(List<int> numbersList, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int,int>();
        for(int i = 0; i < numbersList.Count; i++)
        {
          dic.Add(numbersList[i], i);
        }
        for(int i =0; i < numbersList.Count; i++)
        {
          if(dic.ContainsKey(Math.Abs(target - numbersList[i])))
            return Tuple.Create(i, dic[target - numbersList[i]]);
        }
        return null;
    }
  private static bool IsPalindrome(int number)
  {
    if(number < 10)
      return true;
    int remainder = 0;
    List<int> digits = new List<int>();
    while(number / 10 != 0)
    {
      remainder = number % 10;
      number /= 10;
      digits.Add(remainder);
      //Console.WriteLine(remainder);
    }
    digits.Add(number);
    
    return IsPalindrome(digits);
    
  }
  private static bool IsPalindrome(List<int> digits)
  {
    for(int i = 0 , j = digits.Count - 1; i < j; i++,j--)
    {
      if(digits[i] != digits[j])
        return false;
    }
    return true;
  }

  /*1441
    14441/10 = 1444
    14441 % 10 = 1
    144 / 10 = 14
    144 % 10 = 4


    1, 4, 4, 1*/

// Task#2
// Given an integer x, return true if x is palindrome integer.

// An integer is a palindrome when it reads the same backward as forward.

// For example, 121 is a palindrome while 123 is not.
 

// Example 1:
// Input: x = 121
// Output: true
// Explanation: 121 reads as 121 from left to right and from right to left.
// Example 2:


// Example 2:
// Input: x = 14
// Output: false
// Explanation: Reads 41 from right to left. Therefore it is not a palindrome.


}