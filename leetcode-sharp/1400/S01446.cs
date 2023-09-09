namespace leetcode_sharp;

// 1446. Consecutive Characters
// https://leetcode.com/problems/consecutive-characters/
public class S01446
{
    public int MaxPower(string s)
    {
        var max = 0;
        var count = 0;
        var prev = '\0';

        foreach (var c in s)
        {
            if (c == prev)
            {
                count++;
            }
            else
            {
                max = Math.Max(max, count);
                count = 1;
                prev = c;
            }
        }

        return Math.Max(max, count);
    }
}