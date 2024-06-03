namespace leetcode_sharp;

// 2486. Append Characters to String to Make Subsequence
// https://leetcode.com/problems/append-characters-to-string-to-make-subsequence
public class S02486
{
    public int AppendCharacters(string s, string t)
    {
        var sourceIndex = 0;
        var targetIndex = 0;

        while (sourceIndex < s.Length && targetIndex < t.Length)
        {
            if (s[sourceIndex] == t[targetIndex])
            {
                targetIndex++;
            }

            sourceIndex++;
        }

        return t.Length - targetIndex;
    }
}