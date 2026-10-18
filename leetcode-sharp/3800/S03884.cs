namespace leetcode_sharp;

// 3884. First Matching Character From Both Ends
// https://leetcode.com/problems/first-matching-character-from-both-ends
public class S03884
{
    public int FirstMatchingIndex(string s)
    {
        var n = s.Length;

        for (var i = 0; i <= n / 2; i++)
        {
            if (s[i] == s[n - i - 1])
            {
                return i;
            }
        }

        return -1;
    }
}