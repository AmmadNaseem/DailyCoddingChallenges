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

            Console.WriteLine("Day2: Two strings are anagram to each other:");

            Console.Write("Enter First String:");
            string str1 = Console.ReadLine();

            Console.Write("Enter 2nd String:");
            string str2 = Console.ReadLine();


            StringUtils.Anagram(str1, str2);

        }
    }
}