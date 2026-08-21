namespace leetcode_sharp;

// 3116. Kth Smallest Amount With Single Denomination Combination
// https://leetcode.com/problems/kth-smallest-amount-with-single-denomination-combination
public class S03116
{
    public long FindKthSmallest(int[] coins, int k)
    {
        var n = coins.Length;
        var dictionary = new Dictionary<int, List<long>>();

        for (var i = 1; i <= n; i++)
        {
            dictionary[i] = [];
            GenerateCombinations(coins, i, 0, 1, dictionary[i]);
        }

        long start = coins.Min();
        var end = start * k;

        while (start + 1 < end)
        {
            var mid = start + (end - start) / 2;

            if (Count(mid, n, dictionary) >= k)
            {
                end = mid;
            }
            else
            {
                start = mid;
            }
        }

        return Count(start, n, dictionary) >= k ? start : end;
    }

    private static long Count(long target, int n, Dictionary<int, List<long>> dictionary)
    {
        var count = 0L;

        for (var i = 1; i <= n; i++)
        {
            foreach (var lcm in dictionary[i])
            {
                var value = target / lcm;

                if (i % 2 == 1)
                {
                    count += value;
                }
                else
                {
                    count -= value;
                }
            }
        }

        return count;
    }

    private static void GenerateCombinations(int[] coins, int size, int index, long currentLcm, List<long> result)
    {
        if (size == 0)
        {
            result.Add(currentLcm);
            return;
        }

        for (var i = index; i <= coins.Length - size; i++)
        {
            var nextLcm = Lcm(currentLcm, coins[i]);
            GenerateCombinations(coins, size - 1, i + 1, nextLcm, result);
        }
    }

    private static long Lcm(long a, long b)
    {
        return a / Gcd(a, b) * b;
    }

    private static long Gcd(long a, long b)
    {
        while (b != 0)
        {
            var temp = a % b;
            a = b;
            b = temp;
        }

        return a;
    }
}