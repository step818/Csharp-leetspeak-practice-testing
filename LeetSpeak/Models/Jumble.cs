using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetSpeak
{
  public class Jumble
  {
    public string Dyslexia(string userSentence)
    {
      List<string> final = new List<string>();
      string[] strArray = userSentence.Split(" ");
      Console.WriteLine(strArray.Length);
      for (int i = 0, iLast = strArray.Length; i < iLast; i++)
      {
        //below is for grabbing center letters for jumbling
        char[] brokenWord = strArray[i].ToCharArray();
        List<char> temp = new List<char>();
        List<char> secondHalf = new List<char>();
        int mid = (brokenWord.Length) / 2;
        int cycle = 0;
        // Always add the first letter back in to temp from the start
        temp.Add(brokenWord[0]);
        if(brokenWord.Length % 2 != 0)
        {
          for(int j = 1; j < mid; j++ )
          {
            int jLast = brokenWord.Length - 2 - cycle;
            if(j % 2 != 0)
            {
              temp.Add(brokenWord[jLast]);
              secondHalf.Add(brokenWord[j]);
            
            }
            else
            {
              temp.Add(brokenWord[jLast-1]);
              secondHalf.Add(brokenWord[j]);
              cycle += 1;
            }
            
          }
          secondHalf.Add(brokenWord[mid]);
          temp.AddRange(secondHalf);
          temp.Add(brokenWord[brokenWord.Length-1]);
          // Dont add a blank space after the last word of the string array
          
        }
        else if(brokenWord.Length % 2 == 0)
        {
          
        }
        if(i < iLast-1)
          {
            temp.Add(' ');
          }
        string combinedTemp = string.Join("", temp);
        final.Add(combinedTemp);
      }
      
      
      return String.Join("", final);
    }
  }
}