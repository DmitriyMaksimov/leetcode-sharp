namespace leetcode_sharp;

// 1837. Sum of Digits in Base K
// https://leetcode.com/problems/sum-of-digits-in-base-k/
public class S01837
{
    public int SumBase(int n, int k)
    {
        var result = 0;

        while (n > 0)
        {
            result += n % k;
            n /= k;
        }

        return result;
    }
}