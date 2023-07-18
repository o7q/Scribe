using System;
using System.IO;

namespace Scribe.Tools
{
    public static class Strings
    {
        public static Tuple<bool, int> StringContainsSubstring(string mainString, string subString, bool caseSensitive)
        {
            int count;
            bool containsText;

            if (caseSensitive)
            {
                count = CountStringOccurences(mainString, subString, true);
                containsText = mainString.Contains(subString);
            }
            else
            {
                count = CountStringOccurences(mainString, subString, false);
                containsText = mainString.IndexOf(subString, StringComparison.OrdinalIgnoreCase) >= 0;
            }

            return Tuple.Create(containsText, count);
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
    }
}