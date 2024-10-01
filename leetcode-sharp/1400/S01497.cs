namespace leetcode_sharp;

// 1497. Check If Array Pairs Are Divisible by k
// https://leetcode.com/problems/check-if-array-pairs-are-divisible-by-k
public class S01497
{
    public bool CanArrange(int[] arr, int k)
    {
        var frequencies = new int[k];

        foreach (var num in arr)
        {
            var remainder = (num % k + k) % k;
            frequencies[remainder]++;
        }

        if (frequencies[0] % 2 != 0)
        {
            return false;
        }

        for (var i = 1; i <= k / 2; i++)
        {
            if (frequencies[i] != frequencies[k - i])
            {
                return false;
            }
        }

        return true;
    }
}
