namespace leetcode_sharp;

// 1887. Reduction Operations to Make the Array Elements Equal
// https://leetcode.com/problems/reduction-operations-to-make-the-array-elements-equal
public class S01887
{
    public int ReductionOperations(int[] nums)
    {
        Array.Sort(nums);

        var result = 0;

        for (var i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i] != nums[i - 1])
            {
                result += nums.Length - i;
            }
        }

        return result;
    }
}