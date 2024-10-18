namespace leetcode_sharp;

// 2829. Determine the Minimum Sum of a k-avoiding Array
// https://leetcode.com/problems/determine-the-minimum-sum-of-a-k-avoiding-array
public class S02829
{
    public int MinimumSum(int n, int k)
    {
        var sum = 0;
        var last = Math.Max(n, k - 1);

        for (var i = 1; i <= n; ++i)
        {
            sum += i;
            if (k - i > i && k - i <= n)
            {
                sum += ++last - (k - i);
            }
        }

        return sum;
    }
}
