using System;

namespace MergeStringsAlternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1768.
            //string word1 = "abc";
            //string word2 = "pqr";
            //string word1 = "ab";
            //string word2 = "pqrs";
            //string word1 = "abcd";
            //string word2 = "pq";
            Console.Write("Word1: ");
            string word1 = Console.ReadLine();
            Console.Write("Word2: ");
            string word2 = Console.ReadLine();

            string fullWord = Solution.MergeAlternately(word1, word2);
            Console.WriteLine($"Fullword: {fullWord}");

            Console.WriteLine("Done processing");
            Console.ReadLine();
        }
    }
}
