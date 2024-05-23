namespace leetcode_sharp;

// 2597. The Number of Beautiful Subsets
// https://leetcode.com/problems/the-number-of-beautiful-subsets
public class S02597
{
    public int BeautifulSubsets(int[] nums, int k)
    {
        var result = 1;

        Dictionary<int, Dictionary<int, int>> freq = [];

        foreach (var num in nums)
        {
            var fr = freq.GetValueOrDefault(num % k, new Dictionary<int, int>());
            fr[num] = fr.GetValueOrDefault(num) + 1;
            freq[num % k] = fr;
        }

        foreach (var fr in freq.OrderBy(x => x.Key))
        {
            var prevNum = -k;
            var prev2 = 0;
            var prev1 = 1;
            var curr = 1;

            foreach (var (num, f) in fr.Value.OrderBy(x => x.Key))
            {
                var skip = prev1;
                var take = ((1 << f) - 1) * (num - prevNum == k ? prev2 : prev1);
                curr = skip + take;
                prev2 = prev1;
                prev1 = curr;
                prevNum = num;
            }
            result *= curr;
        }

        return result - 1;
    }
}