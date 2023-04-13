using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCoddingChallenges.Problems
{

    public static class StringUtils
    {
        public static string RemoveDuplicates(string str)
        {
            string duplicateValues = "";
            string newStr = "";

            foreach (char value in str)
            {
                if (duplicateValues.IndexOf(value) == -1)
                {
                    duplicateValues += value;
                    newStr += value;
                }
            }

            return newStr;
        }

        public static string PrintDuplicate(string str)
        {
            string duplicateValues = "";
            string newStr = "";
            string printDuplicateTable = "";

            foreach (char value in str)
            {
                if (duplicateValues.IndexOf(value) == -1)
                {
                    duplicateValues += value;
                }
                else
                {
                    if (printDuplicateTable.IndexOf(value) == -1)
                    {
                        printDuplicateTable += value;
                        newStr += value;

                    }
                }
            }

            return newStr;
        }

        //Two words are said to be Anagrams of each other if they share the
        //same set of letters to form the respective words.
        //for an example: Silent–>Listen, post–>opts.
        public static void Anagram(string str1, string str2)
        {
            char[] strOne=str1.ToCharArray();
            char[] strTwo=str2.ToCharArray();

            Array.Sort(strOne);
            Array.Sort(strTwo);

            string newStr1 = new string(strOne);
            string newStr2=new string(strTwo);

            if (newStr1==newStr2)
            {
                Console.WriteLine("Yes! Strings \"{0}\" and \"{1}\" are Anagrams", str1, str2);
            }
            else
            {
                Console.WriteLine("No! Strings \"{0}\" and \"{1}\" are not Anagrams", str1, str2);
            }


        }
    }

}
