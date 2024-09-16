namespace leetcode_sharp;

// 1753. Maximum Score From Removing Stones
// https://leetcode.com/problems/maximum-score-from-removing-stones
public class S01753
{
    public int MaximumScore(int a, int b, int c)
    {
        if (a < b)
        {
            return MaximumScore(b, a, c);
        }

        if (b < c)
        {
            return MaximumScore(a, c, b);
        }

        return b == 0 ? 0 : MaximumScore(a - 1, b - 1, c) + 1;
    }
}
