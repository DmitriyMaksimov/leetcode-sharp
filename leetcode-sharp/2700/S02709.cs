namespace leetcode_sharp;

// 2709. Greatest Common Divisor Traversal
// https://leetcode.com/problems/greatest-common-divisor-traversal
public class S02709
{
    public bool CanTraverseAllPairs(int[] nums)
    {
        var n = nums.Length;
        if (n == 1)
        {
            return true;
        }

        var f = new int[n];
        var num = new int[n];

        for (var i = 0; i < n; ++i)
        {
            f[i] = i;
            num[i] = 1;
        }

        var have = new Dictionary<int, int>();
        for (var i = 0; i < n; ++i)
        {
            var x = nums[i];
            if (x == 1)
            {
                return false;
            }

            for (var d = 2; d * d <= x; ++d)
            {
                if (x % d != 0) continue;
                
                if (have.TryGetValue(d, out var value))
                {
                    merge(f, num, i, value);
                }
                else
                {
                    have.Add(d, i);
                }

                while (x % d == 0)
                {
                    x /= d;
                }
            }

            if (x <= 1) continue;
            if (!have.TryAdd(x, i))
            {
                merge(f, num, i, have[x]);
            }
        }

        return num[getf(f, 0)] == n;
    }

    private static int getf(int[] f, int x)
    {
        return f[x] == x ? x : f[x] = getf(f, f[x]);
    }

    private static void merge(int[] f, int[] num, int x, int y)
    {
        x = getf(f, x);
        y = getf(f, y);

        if (x == y)
        {
            return;
        }

        if (num[x] < num[y])
        {
            (x, y) = (y, x);
        }

        f[y] = x;
        num[x] += num[y];
    }
}