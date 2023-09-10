namespace leetcode_sharp;

// 1624. Largest Substring Between Two Equal Characters
// https://leetcode.com/problems/largest-substring-between-two-equal-characters/
public class S01624
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        var max = -1;
        
        for (var i = 0; i < s.Length; i++)
        {
            var j = s.LastIndexOf(s[i]);
            if (j > i)
            {
                max = Math.Max(max, j - i - 1);
            }
        }

        return max;
    }
}