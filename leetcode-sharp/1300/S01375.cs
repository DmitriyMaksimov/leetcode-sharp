namespace leetcode_sharp;

// 1375. Number of Times Binary String Is Prefix-Aligned
// https://leetcode.com/problems/number-of-times-binary-string-is-prefix-aligned
public class S01375
{
    public int NumTimesAllBlue(int[] flips)
    {
        var right = 0;
        var result = 0;

        for (var i = 0; i < flips.Length; ++i)
        {
            right = Math.Max(right, flips[i]);
            if (right == i + 1)
            {
                ++result;
            }
        }

        return result;
    }
}
