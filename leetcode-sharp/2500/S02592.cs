namespace leetcode_sharp;

// 2592. Maximize Greatness of an Array
// https://leetcode.com/problems/maximize-greatness-of-an-array
public class S02592
{
    public int MaximizeGreatness(int[] nums)
    {
        Array.Sort(nums);

        var result = 0;

        foreach (var num in nums)
        {
            if (num > nums[result])
            {
                result++;
            }
        }

        return result;
    }
}
