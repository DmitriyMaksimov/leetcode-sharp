using System.Text;

namespace leetcode_sharp;

// 68. Text Justification
// https://leetcode.com/problems/text-justification/
public class S00068
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        var result = new List<string>();
        var currentLine = new List<string>();
        var currentLength = 0;

        foreach (var word in words)
        {
            if (currentLength + currentLine.Count + word.Length > maxWidth)
            {
                var numWords = currentLine.Count;
                var numSpaces = maxWidth - currentLength;
                var justifiedLine = "";

                if (numWords == 1)
                {
                    justifiedLine = currentLine[0] + new string(' ', numSpaces);
                }
                else
                {
                    var spacesBetweenWords = numSpaces / (numWords - 1);
                    var extraSpaces = numSpaces % (numWords - 1);

                    var sb = new StringBuilder();

                    for (var i = 0; i < numWords - 1; i++)
                    {
                        sb.Append(currentLine[i]);
                        sb.Append(new string(' ', spacesBetweenWords));

                        if (i < extraSpaces)
                        {
                            sb.Append(' ');
                        }
                    }

                    sb.Append(currentLine[numWords - 1]);
                    justifiedLine = sb.ToString();
                }

                result.Add(justifiedLine);
                currentLine.Clear();
                currentLength = 0;
            }

            currentLine.Add(word);
            currentLength += word.Length;
        }

        var lastLine = string.Join(" ", currentLine);
        lastLine += new string(' ', maxWidth - lastLine.Length);
        result.Add(lastLine);

        return result;
    }
}