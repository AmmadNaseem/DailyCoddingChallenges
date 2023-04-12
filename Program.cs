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
            Console.WriteLine("Day1: Remove Duplicate Character in a String:");

            Console.Write("Enter String:");
            string str = Console.ReadLine();

            string newStr = StringUtils.RemoveDuplicates(str);

            Console.WriteLine($"Final String is:{newStr}");

            string duplicateChar = StringUtils.PrintDuplicate(str);

            Console.WriteLine($"Duplicated Characters in String is:{duplicateChar}");


        }
    }
}