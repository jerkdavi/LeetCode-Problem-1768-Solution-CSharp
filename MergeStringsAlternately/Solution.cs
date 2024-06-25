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
            for (int i = 0; i < 100; i++)
            {
                if (i < word1.Length) { fullWord += word1[i]; }
                if (i < word2.Length) { fullWord += word2[i]; }
            }
            return fullWord;
        }
    }
}
