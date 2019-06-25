using System;

namespace Dictionaries
{
   class TwoStrings 
   {
       static bool CheckTwoStrings(string s1, string s2)
       {
        const int max = 26;
         
        // defaults to false
        bool []v = new bool[max];
         
//        for (int i = 0; i < max; i++)
//        {
//           v[i]=false;
//        }

        for (int i = 0; i < s1.Length; i++)
        {
           // The int representation of a lowercase character - 'a' gives the index of that letter in the alphabet
           // Marking it true to show that we've found one of that character
           v[s1[i] - 'a'] = true;
        }

        // checking common substring of str2 in str1 
        for (int i = 0; i < s2.Length; i++)
        {
           // Once we find a true, can return true
           if (v[s2[i] - 'a'] == true)
           {
               return true;
           }
        }
            
        // No matching characters, return false
        return false;      
   } 
         
      public static void Main ()  
      { 
         // Needs to be between a-z, no spaces/upper/etc
         string s1 = "helloworld"; 
         string s2 = "ienjoytacos";
         bool result = CheckTwoStrings(s1, s2);
         Console.WriteLine(result);
      } 
   } 
}