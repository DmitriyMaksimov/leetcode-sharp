namespace leetcode_sharp;

// 2560. House Robber IV
// https://leetcode.com/problems/house-robber-iv
public class S02560
{
    public int MinCapability(int[] nums, int k)
    {
        var low = 0;
        var high = 1_000_000_001;

        while (low < high)
        {
            var mid = low + (high - low) / 2;
            if (Helper(nums, k, mid))
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;
    }

    private static bool Helper(int[] nums, int k, int mid)
    {
        var i = 0;
        var n = nums.Length;

        while (i < n)
        {
            if (nums[i] <= mid)
            {
                k--;
                i += 2;
            }
            else
            {
                i++;
            }

            if (k == 0)
            {
                return true;
            }
        }

        return k == 0;
    }
}
