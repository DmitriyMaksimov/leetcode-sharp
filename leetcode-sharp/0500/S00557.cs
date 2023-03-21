using System.Text;

namespace leetcode_sharp;

// 557. Reverse Words in a String III
// https://leetcode.com/problems/reverse-words-in-a-string-iii/
public class S00557
{
    public string ReverseWords(string s)
    {
        var stringBuilder = new StringBuilder();
        var stack = new Stack<char>();
        foreach (var ch in s)
        {
            if (char.IsWhiteSpace(ch))
            {
                while (stack.TryPop(out var c))
                {
                    stringBuilder.Append(c);
                }

                stringBuilder.Append(ch);
            }
            else
            {
                stack.Push(ch);
            }
        }

        while (stack.TryPop(out var c))
        {
            stringBuilder.Append(c);
        }
        
        return stringBuilder.ToString();
    }
}