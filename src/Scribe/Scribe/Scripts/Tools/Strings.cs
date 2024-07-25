using System;

namespace Scribe.Tools
{
    public static class Strings
    {
        public static int StringContainsSubstring(string mainString, string subString, bool caseSensitive)
        {
            int count = 0;

            if (caseSensitive)
            {
                if (mainString.Contains(subString))
                {
                    count = CountStringOccurences(mainString, subString, true);
                }
            }
            else if (mainString.IndexOf(subString, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                count = CountStringOccurences(mainString, subString, false);
            }

            return count;
        }

        public static int CountStringOccurences(string mainString, string subString, bool caseSensitive)
        {
            int occurrences = 0;
            int startIndex = 0;
            StringComparison comparison = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

            while ((startIndex = mainString.IndexOf(subString, startIndex, comparison)) != -1)
            {
                occurrences++;
                startIndex += subString.Length;
            }

            return occurrences;
        }

        public static string Pluralize(int number)
        {
            if (number != 1)
            {
                return "s";
            }
            else
            {
                return "";
            }
        }

        public static string PluralizeTense(int number)
        {
            if (number != 1)
            {
                return "have";
            }
            else
            {
                return "has";
            }
        }
    }
}