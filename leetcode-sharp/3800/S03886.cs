namespace leetcode_sharp;

// 3886. Sum of Sortable Integers
// https://leetcode.com/problems/sum-of-sortable-integers
public class S03886
{
    public int SortableIntegers(int[] nums)
    {
        var n = nums.Length;
        var result = 0;

        for (var k = 1; k <= n; k++)
        {
            if (n % k != 0)
            {
                continue;
            }

            if (IsSortable(nums, k))
            {
                result += k;
            }
        }

        return result;
    }

    private static bool IsSortable(int[] nums, int len)
    {
        var n = nums.Length;
        var min = 0;

        for (var i = 0; i < n; i += len)
        {
            if (nums[i] < min)
            {
                return false;
            }

            var max = nums[i];
            var point = false;

            for (var j = i + 1; j < i + len; j++)
            {
                if (nums[j] < min)
                {
                    return false;
                }

                if (nums[j - 1] > nums[j])
                {
                    if (point)
                    {
                        return false;
                    }

                    point = true;
                }

                max = Math.Max(max, nums[j]);
            }

            if (point)
            {
                if (nums[i] < nums[i + len - 1])
                {
                    return false;
                }
            }

            min = max;
        }

        return true;
    }
}