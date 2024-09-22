namespace leetcode_sharp;

// 440. K-th Smallest in Lexicographical Order
// https://leetcode.com/problems/k-th-smallest-in-lexicographical-order
public class S00440
{
    public int FindKthNumber(int n, int k)
    {
        var current = 1;

        while (--k > 0)
        {
            var steps = CalculateSteps(n, current, current + 1);

            if (steps <= k)
            {
                current++;
                k -= steps - 1;
            }
            else
            {
                current *= 10;
            }
        }

        return current;
    }

    private static int CalculateSteps(int n, long n1, long n2)
    {
        var steps = 0L;

        while (n1 <= n)
        {
            steps += Math.Min(n + 1, n2) - n1;
            n1 *= 10;
            n2 *= 10;
        }

        return (int)steps;
    }
}
