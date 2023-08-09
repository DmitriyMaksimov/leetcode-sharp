namespace leetcode_sharp;

// 2616. Minimize the Maximum Difference of Pairs
// https://leetcode.com/problems/minimize-the-maximum-difference-of-pairs/
public class S02616
{
    public int MinimizeMax(int[] nums, int p)
    {
        Array.Sort(nums);

        var left = 0;
        var right = nums[^1] - nums[0];

        while (left < right)
        {
            var mid = (left + right) / 2;
            if (canFormPairs(nums, mid, p))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    private static bool canFormPairs(int[] nums, int mid, int p)
    {
        var count = 0;
        for (var i = 0; i < nums.Length - 1 && count < p;)
        {
            if (nums[i + 1] - nums[i] <= mid)
            {
                count++;
                i += 2;
            }
            else
            {
                i++;
            }
        }

        return count >= p;
    }
}