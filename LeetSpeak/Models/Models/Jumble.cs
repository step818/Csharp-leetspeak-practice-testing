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
        int mid = (brokenWord.Length) / 2;
        int cycle = 0;
        temp.Add(brokenWord[0]);
        
        for(int j = 1; j < mid; j++ )
        {
          int jLast = brokenWord.Length - 2 - cycle;
          if(j % 2 != 0)
          {
            // char ogFirst = brokenWord[j];
            // char ogLast = brokenWord[jLast];
            // brokenWord[j] = ogLast;
            // brokenWord[jLast] = ogFirst;
            temp.Add(brokenWord[jLast]);
            Console.WriteLine(temp[0]);
            temp.Insert(brokenWord.Length-2-cycle, brokenWord[j]);
          
          }
          else
          {
            // char ogFirst = brokenWord[j];
            // brokenWord[j] = brokenWord[mid];
            // brokenWord[mid] = ogFirst;
            temp.Add(brokenWord[mid]);
            temp.Insert(mid, brokenWord[j]);
            cycle += 1;
          }
        
        }
        // temp.Insert((brokenWord.Length - 1), brokenWord[brokenWord.Length - 1]);
        temp.Add(brokenWord[brokenWord.Length-1]);
        // Dont add a blank space after the last word of the string array
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