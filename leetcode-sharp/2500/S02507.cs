namespace leetcode_sharp;

// 2507. Smallest Value Represented As Sum Of Two Distinct Positive Integers
// https://leetcode.com/problems/smallest-value-after-replacing-with-sum-of-prime-factors/
public class S02507
{
    public int SmallestValue(int n)
    {
        if (n == 4)
        {
            return 4;
        }

        var list = new List<int>();

        for (var i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                n /= i;
                list.Add(i);
            }
        }

        if (list.Count == 1)
        {
            return list[0];
        }

        var result = list.Sum();

        return SmallestValue(result);
    }
}