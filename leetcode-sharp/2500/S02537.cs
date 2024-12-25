namespace leetcode_sharp;

// 2537. Count the Number of Good Subarrays
// https://leetcode.com/problems/count-the-number-of-good-subarrays
public class S02537
{
    public long CountGood(int[] nums, int k)
    {
        var left = 0;
        var right = 0;
        var n = nums.Length;
        var freqMap = new Dictionary<int, int>();
        var count = 0L;
        var result = 0L;

        while (right < n)
        {
            freqMap[nums[right]] = freqMap.GetValueOrDefault(nums[right]) + 1;
            count += freqMap[nums[right]] - 1;

            while (left < right && count >= k)
            {
                result += n - right;
                freqMap[nums[left]]--;

                if (freqMap[nums[left]] == 0)
                {
                    freqMap.Remove(nums[left]);
                }

                count -= freqMap.GetValueOrDefault(nums[left]);
                left++;
            }

            right++;
        }

        return result;
    }
}
