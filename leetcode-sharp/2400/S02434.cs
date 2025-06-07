using System.Text;

namespace leetcode_sharp;

// 2434. Using a Robot to Print the Lexicographically Smallest String
// https://leetcode.com/problems/using-a-robot-to-print-the-lexicographically-smallest-string
public class S02434
{
    public string RobotWithString(string s)
    {
        var stack = new Stack<char>();
        var frequencies = new int[26];

        foreach (var ch in s)
        {
            frequencies[ch - 'a']++;
        }

        var stringBuilder = new StringBuilder();

        foreach (var ch in s)
        {
            stack.Push(ch);
            frequencies[ch - 'a']--;

            while (stack.Count > 0 && stack.Peek() <= SmallestChar(frequencies))
            {
                stringBuilder.Append(stack.Pop());
            }
        }

        while (stack.Count > 0)
        {
            stringBuilder.Append(stack.Pop());
        }

        return stringBuilder.ToString();
    }

    private static char SmallestChar(int[] freq)
    {
        for (var i = 0; i < 26; i++)
        {
            if (freq[i] > 0)
            {
                return (char)('a' + i);
            }
        }

        return 'a';
    }
}
