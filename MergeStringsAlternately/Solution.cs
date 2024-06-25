using System;
using System.Collections.Generic;
using System.Text;

namespace MergeStringsAlternately
{
    public class Solution
    {
        public static string MergeAlternately(string word1, string word2) 
        {
            string fullWord = "";
            int counter = word1.Length + word2.Length;
            for (int i = 0; i < counter; i++)
            {
                if (i < word1.Length) { fullWord += word1[i]; }
                if (i < word2.Length) { fullWord += word2[i]; }
            }
            return fullWord;
        }
    }
}
