namespace leetcode_sharp;

// 3392. Count Subarrays of Length Three With a Condition
// https://leetcode.com/problems/count-subarrays-of-length-three-with-a-condition
public class S03392
{
    public int CountSubarrays(int[] nums)
    {
        var result = 0;

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if ((nums[i] + nums[i + 2]) * 2 == nums[i + 1])
            {
                ++result;
            }
        }

        return result;
    }
}
