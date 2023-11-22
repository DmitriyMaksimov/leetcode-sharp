namespace leetcode_sharp;

// 1814. Count Nice Pairs in an Array
// https://leetcode.com/problems/count-nice-pairs-in-an-array
public class S01814
{
    public int CountNicePairs(int[] nums)
    {
        const int mod = 1_000_000_007;
        var count = 0;

        var map = new Dictionary<long, int>();

        foreach (var num in nums)
        {
            var rev = reverse(num);

            var diff = num - rev;
            if (map.TryGetValue(diff, out var value))
            {
                count = (count % mod + value % mod) % mod;
            }

            map[diff] = map.GetValueOrDefault(diff) + 1;
        }

        return count;
    }

    private static long reverse(int num)
    {
        var rev = 0L;
        
        while (num != 0)
        {
            rev = rev * 10 + num % 10;
            num /= 10;
        }

        return rev;
    }
}