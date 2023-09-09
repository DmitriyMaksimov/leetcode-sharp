namespace leetcode_sharp;

// 1422. Maximum Score After Splitting a String
// https://leetcode.com/problems/maximum-score-after-splitting-a-string/
public class S01422
{
    public int MaxScore(string s)
    {
        var max = 0;
        var left = 0;
        var right = s.Count(t => t == '1');

        foreach (var c in s)
        {
            if (c == '0')
            {
                left++;
            }
            else
            {
                right--;
            }

            max = Math.Max(max, left + right);
        }

        return max;
    }
}