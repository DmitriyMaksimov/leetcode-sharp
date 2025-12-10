namespace leetcode_sharp;

// 3583. Count Special Triplets
// https://leetcode.com/problems/count-special-triplets/description
public class S03583
{
    public int SpecialTriplets(int[] nums)
    {
        const int mod = 1_000_000_007;
        var result = 0L;

        var c1 = new Dictionary<int, int>();
        var c2 = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (num % 2 == 0)
            {
                if (c2.TryGetValue(num / 2, out var val))
                {
                    result = (result + val) % mod;
                }
            }

            var c1Double = c1.GetValueOrDefault(num * 2, 0);
            var c2Current = c2.GetValueOrDefault(num, 0);
            c2[num] = (c2Current + c1Double) % mod;
            c1[num] = c1.GetValueOrDefault(num) + 1;
        }

        return (int)result;
    }
}