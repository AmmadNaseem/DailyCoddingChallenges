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
    }

}
