namespace leetcode_sharp;

// 3411. Maximum Subarray With Equal Products
// https://leetcode.com/problems/maximum-subarray-with-equal-products
public class S03411
{
    public int MaxLength(int[] nums)
    {
        var result = 2;
        var last = new Dictionary<int, int>();
        var i = 0;

        for (var j = 0; j < nums.Length; j++)
        {
            var x = nums[j];

            foreach (var p in PrimeDivisors(x))
            {
                if (last.TryGetValue(p, out var value))
                {
                    i = Math.Max(i, value + 1);
                }

                last[p] = j;
            }

            result = Math.Max(result, j - i + 1);
        }

        return result;
    }

    private static IEnumerable<int> PrimeDivisors(int n)
    {
        var d = 2;

        while (d <= Math.Sqrt(n))
        {
            if (n % d == 0)
            {
                yield return d;
                n /= d;

                while (n % d == 0)
                {
                    n /= d;
                }
            }

            d += (d & 1) + 1;
        }

        if (n > 1)
        {
            yield return n;
        }
    }
}
