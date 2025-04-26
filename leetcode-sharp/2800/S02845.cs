namespace leetcode_sharp;

// 2845. Count of Interesting Subarrays
// https://leetcode.com/problems/count-of-interesting-subarrays
public class S02845
{
    public long CountInterestingSubarrays(IList<int> nums, int modulo, int k)
    {
        var result = 0L;
        var prefix = 0L;
        var n = nums.Count;
        var dictionary = new Dictionary<long, long> { [0] = 1 };

        for (var i = 0; i < n; i++)
        {
            if (nums[i] % modulo == k)
            {
                prefix++;
            }

            prefix %= modulo;
            var key = (prefix - k + modulo) % modulo;

            if (dictionary.TryGetValue(key, out var value))
            {
                result += value;
            }

            dictionary[prefix] = dictionary.GetValueOrDefault(prefix) + 1;
        }

        return result;
    }
}
