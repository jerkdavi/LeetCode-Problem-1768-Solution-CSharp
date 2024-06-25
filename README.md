# SOLUTION TO LEETCODE PROBLEM 1768 - C#

This is my solution to LeetCode Problem 1768 - **Merge Strings Alternately** - in C# and a brief explanation

Link to problem on LeetCode -> [https://leetcode.com/problems/merge-strings-alternately/](https://leetcode.com/problems/merge-strings-alternately/)

## PROJECT EXPLANATION

I have created a new project in _Visual Studio 2022 Community Edition_, selected the **Console App** project template, named the project **MergeStringsAlternately**, selected _.NET Core 3.1 (Out of support) Framework_.

I have two classes, **Program** class and **Solution** class.

## CODE EXPLANATION

### Program class 

I am using the automatically generated **Program** class and **Main** function.

```cs
internal class Program
{
    static void Main(string[] args)
    {
```

Firstly, the **word1** and **word2** strings are being initialized by using basic string initialization. This part of code is commented out currently.

```cs
string word1 = "abc";
string word2 = "pqr";
```

Currently, the **word1** and **word2** strings are being initialized by using next structure:

- Console Write -> where it is evident which word needs to be inputted.
- string input = Console ReadLine -> where user input is being stored into a variable.

```cs
Console.Write("Word1: ");
string word1 = Console.ReadLine();
Console.Write("Word2: ");
string word2 = Console.ReadLine();
```

Next, the **MergeAlternately** function from **Solution** class is being called. It takes two strings (_string word1, string word_) and returns one string (_string fullWord_). The returned string is being stored into a new string named **fullWord**.
The returned string is then printed out to the console.

```cs
string fullWord = Solution.MergeAlternately(word1, word2);
Console.WriteLine(fullWord);
```

At the end of the **Program** class there is next structure:

- Console WriteLine -> displaying that the code is done processing.
- Console ReadLine -> where it is waiting for user input. Why are we waiting for user input? -> To stop the code from automatically completing and exiting and us not being able to check the result of the code.

```cs
Console.WriteLine("Done processing");
Console.ReadLine();
```

### Solution class 

I have created a new class and named it **Solution**. I have made it public. I have created the **MergeAlternately** function to replicate the example from LeetCode problem. I have made it static.

```cs
public class Solution
{
    public static string MergeAlternately(string word1, string word2) 
    {
```

Firstly, the **fullWord** string is being initialized by using basic string initialization. It is set as empty string. This string will be used to store the merged string to and return it at the end of the function.

The **counter** int is being initialized by using basic int initialization. It is set as _word1 + word2 Length_. This int will be used for specifying the number of times the **for** loop needs to run.

```cs
string fullWord = "";
int counter = word1.Length + word2.Length;
```

Secondly, the **for** function is created that iterates from _0_ to _counter_.

```cs
for (int i = 0; i < counter; i++)
{
```

Inside the **for** function, there are two **if** functions. Both check if **i** is less than _Length of the specified word_.

- If it is less -> the intuition is that the word **HAS** letters remaining -> and it adds the specified letter of the specified word to the fullWord string.
- If it is greater -> the intuition is that the word does **NOT HAVE** letters remaining -> and it does not run the code after the if function.

The order of the words is important, as firstly the letter from the **word1** needs to be taken, and then the letter from the **word2**.

Notice that string letters (or characters) can be accessed by using ```word[i]```.

```cs
if (i < word1.Length) { fullWord += word1[i]; }
if (i < word2.Length) { fullWord += word2[i]; }
```

At the end of the **Solution** class, the **fullWord** string is being returned.

```cs
return fullWord;
```

## POTENTIAL MISTAKES (I HAVE MADE)

In Solution class, instead of initializing the **counter** variable, setting it as _word1 + word2 Length_, and using it in the **for** loop as the _count to value_, I have hardcoded the value of **100** to be the value the for loop counts to.

I made this error based on the assumption on the constraint given in the problem itself -> ```1 <= word1.length, word2.length <= 100```

```cs
for (int i = 0; i < 100; i++)
{
```

Even though this is **NOT WRONG**, it **IS TIME INEFFICIENT** because it goes through **200** iterations every time, no matter the _length of the words_.

## RUNNING THE CODE - RESULT

![image](https://github.com/jerkdavi/LeetCode-Problem-1768-Solution-CSharp/assets/75536158/481d33a4-bb2e-41b5-9f5b-4595a3b423ba) ![image](https://github.com/jerkdavi/LeetCode-Problem-1768-Solution-CSharp/assets/75536158/38bb35f7-6833-4ae4-81a8-70241c75ab2d) ![image](https://github.com/jerkdavi/LeetCode-Problem-1768-Solution-CSharp/assets/75536158/02ee0613-5050-4674-b712-31886ff8ee17) 
