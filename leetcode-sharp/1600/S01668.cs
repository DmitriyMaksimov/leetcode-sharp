using System.Text;

namespace leetcode_sharp;

// 1668. Maximum Repeating Substring
// https://leetcode.com/problems/maximum-repeating-substring/
public class S01668
{
    public int MaxRepeating(string sequence, string word)
    {
        var count = 0;
        var sb = new StringBuilder(word);

        while (sequence.Contains(sb.ToString()))
        {
            sb.Append(word);
            count++;
        }

        return count;
    }
}