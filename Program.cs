using static System.Net.Mime.MediaTypeNames;
using System;
using DailyCoddingChallenges.Problems;


namespace DailyCoddingChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Daily Coding Problems************");

            ////====================================DAY-1======================================
            //Console.WriteLine("************Daily Coding Problems************");
            //Console.WriteLine("Day1: Remove Duplicate Character in a String:");

            //Console.Write("Enter String:");
            //string str = Console.ReadLine();

            //string newStr = StringUtils.RemoveDuplicates(str);

            //Console.WriteLine($"Final String is:{newStr}");

            //string duplicateChar = StringUtils.PrintDuplicate(str);

            //Console.WriteLine($"Duplicated Characters in String is:{duplicateChar}");

            ////====================================DAY-2======================================

            //Console.WriteLine("Day2: Two strings are anagram to each other:");

            //Console.Write("Enter First String:");
            //string str1 = Console.ReadLine();

            //Console.Write("Enter 2nd String:");
            //string str2 = Console.ReadLine();


            //StringUtils.Anagram(str1, str2);

            //====================================DAY-2======================================
            Console.WriteLine("Day3: reverse String in C# using Iteration and Recursion:");

            Console.Write("Enter a string:");
            string str=Console.ReadLine();

            // StringUtils.ReseverseStringthroughIteration(str);
            int endSring = str.Length - 1;

            Console.WriteLine(StringUtils.ReverseStringThroughRecursion(str, endSring));



        }
    }
}