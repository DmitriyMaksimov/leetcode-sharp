namespace leetcode_sharp;

// 3420. Count Non-Decreasing Subarrays After K Operations
// https://leetcode.com/problems/count-non-decreasing-subarrays-after-k-operations
public class S03420
{
    public long CountNonDecreasingSubarrays(int[] nums, long k)
    {
        var n = nums.Length;

        for (var i = 0; i < n / 2; ++i)
        {
            (nums[i], nums[n - 1 - i]) = (nums[n - 1 - i], nums[i]);
        }

        var result = 0L;
        var q = new LinkedList<int>();

        for (int j = 0, i = 0; j < nums.Length; ++j)
        {
            while (q.Count > 0 && nums[q.Last!.Value] < nums[j])
            {
                var r = q.Last.Value;
                q.RemoveLast();

                var l = q.Count == 0 ? i - 1 : q.Last.Value;

                k -= 1L * (r - l) * (nums[j] - nums[r]);
            }

            q.AddLast(j);

            while (k < 0)
            {
                k += nums[q.First!.Value] - nums[i];

                if (q.First.Value == i)
                {
                    q.RemoveFirst();
                }

                ++i;
            }

            result += j - i + 1;
        }
        
        return result;
    }
}