namespace leetcode_sharp;

// 1208. Get Equal Substrings Within Budget
// https://leetcode.com/problems/get-equal-substrings-within-budget
public class S01208
{
    public int EqualSubstring(string s, string t, int maxCost)
    {
        var n = s.Length;
        var i = 0;
        int j;
        
        for (j = 0; j < n; ++j)
        {
            maxCost -= Math.Abs(s[j] - t[j]);

            if (maxCost >= 0) continue;
            
            maxCost += Math.Abs(s[i] - t[i]);
            ++i;
        }

        return j - i;
    }
}