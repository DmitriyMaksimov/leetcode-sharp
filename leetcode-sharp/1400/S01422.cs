namespace leetcode_sharp;

// 1422. Maximum Score After Splitting a String
// https://leetcode.com/problems/maximum-score-after-splitting-a-string/
public class S01422
{
    public int MaxScore(string s)
    {
        var zeros = 0;
        var ones = 0;
        var max = int.MinValue;
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                zeros++;
            }
            else
            {
                ones++;
            }

            if (i != s.Length - 1)
            {
                max = Math.Max(zeros - ones, max);
            }
        }

        return max + ones;
    }
}