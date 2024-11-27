namespace leetcode_sharp;

// 2571. Minimum Operations to Reduce an Integer to 0
// https://leetcode.com/problems/minimum-operations-to-reduce-an-integer-to-0
public class S02571
{
    public int MinOperations(int n)
    {
        var result = 0;

        while (n > 0)
        {
            result++;
            var x = Math.Log2(n);

            var prevPower = (int)Math.Pow(2, (int)x);
            var nextPower = (int)Math.Pow(2, (int)x + 1);

            var diff1 = n - prevPower;
            var diff2 = nextPower - n;

            n = Math.Min(diff1, diff2);
        }

        return result;
    }
}
