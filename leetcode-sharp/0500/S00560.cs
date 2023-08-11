namespace leetcode_sharp;

// 560. Subarray Sum Equals K
// https://leetcode.com/problems/subarray-sum-equals-k/
public class S00560
{
    public int SubarraySum(int[] nums, int k)
    {
        var sum = 0;
        var answer = 0;
        var prefixSum = new Dictionary<int, int>
        {
            [sum] = 1
        };

        foreach (var num in nums)
        {
            sum += num;
            var find = sum - k;
            if (prefixSum.TryGetValue(find, out var value))
            {
                answer += value;
            }

            prefixSum[sum] = prefixSum.GetValueOrDefault(sum) + 1;
        }

        return answer;
    }
}