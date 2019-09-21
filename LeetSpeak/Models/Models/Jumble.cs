using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetSpeak
{
  public class Jumble
  {
    public string Dyslexia(string userSentence)
    {
      List<string> result = new List<string>();
      string[] temp = userSentence.Split(" ");
      for (int i = 0, L = temp.Length; i < L; i++)
      {
        Console.WriteLine(temp[i]);
        char[] splword = temp[i].ToCharArray();
        if (splword.Length  <= 3)
        {
          break;
        }
        else
        {
          for(int j = 1, jf = splword.Length-2; j < jf; j += 2, jf--)
          {
            if ( j + 1 == jf )
            {
              //assign original character
              char og1st = splword[j];
              // swap two middle letters
              splword[j] = splword[jf];
              splword[jf] = og1st;
              temp[i] = splword.ToString();
            } 
            else {
              //assign original characters to variables
              int mid1 = jf/2 +1;
              char ogFirst = splword[j];
              char ogLast = splword[jf];
              //swap letters
              splword[j] = splword[mid1];
              splword[jf] = ogFirst;
              splword[mid1] = ogLast;
              temp[i] = splword.ToString();
              Console.WriteLine(temp[i]);
            }
            
          }
          
        }
      }
      //figure how to return a string instead of System.String[]
      string res = string.Join(".", temp);
      return res;
    }
  }
}