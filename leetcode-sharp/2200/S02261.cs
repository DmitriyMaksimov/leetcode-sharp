namespace leetcode_sharp;

// 2261. K Divisible Elements Subarrays
// https://leetcode.com/problems/k-divisible-elements-subarrays
public class S02261
{
    private const long Mod = 1_000_000_007;
    private const int MaxElements = 200;

    public int CountDistinct(int[] nums, int k, int p)
    {
        var count = new int[MaxElements + 1];
        var hash = new int[MaxElements + 1];
        var result = 0;

        for (var sz = 0; sz < nums.Length; ++sz)
        {
            HashSet<int> hashSet = [];

            for (var i = 0; i + sz < nums.Length; ++i)
            {
                if (nums[i + sz] % p == 0)
                {
                    count[i]++;
                }

                if (count[i] <= k)
                {
                    hash[i] = (int)(((long)hash[i] * MaxElements + nums[i + sz]) % Mod);
                    if (hashSet.Add(hash[i]))
                    {
                        result++;
                    }
                }
            }
        }

        return result;
    }
}
