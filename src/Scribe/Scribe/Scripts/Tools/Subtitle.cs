using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Scribe.Tools
{
    public static class Subtitle
    {
        public static string FormatSubRip(string subRip)
        {
            List<string> subRipLines = subRip.Split('\n').ToList<string>();

            StringBuilder sb = new StringBuilder();

            int index = 0;
            int lineBreakLength = 0;

            // parse SubRip
            foreach (string line in subRipLines)
            {
                string formattedLine = line.Replace("\r", "");
                if (!String.IsNullOrWhiteSpace(formattedLine) && !int.TryParse(formattedLine, out _))
                {
                    bool timeLine = index % 2 == 0;
                    string lineBreak = timeLine ? " " : "\n";
                    if (timeLine)
                    {
                        formattedLine = $"[{formattedLine.Replace(',', '.')}]";
                    }
                    sb.Append(formattedLine).Append(lineBreak);
                    index++;

                    lineBreakLength = lineBreak.Length;
                }
            }

            sb.Length -= lineBreakLength;

            return sb.ToString();
        }
    }
}