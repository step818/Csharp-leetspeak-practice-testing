using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetSpeak
{
  public class Jumble
  {
    public string Dyslexia(string userSentence)
    {
      List<char> temp = new List<char>();
      string[] strSentence = userSentence.Split(" ");
      Console.WriteLine(strSentence.Length);
      for (int i = 0; i < strSentence.Length; i++)
      {
        //below is for grabbing center letters for jumbling
        char[] arrSentence = strSentence[i].ToCharArray();
        for(int j = 1 , jLast = arrSentence.Length - 1; j < jLast; j++ )
        {
          temp.Add(arrSentence[j]);

        }
        temp.Add(' ');
        
      }
      
      
      return String.Join("", temp);
    }
  }
}