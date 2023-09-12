namespace leetcode_sharp;

// 1991. Find the Middle Index in Array
// https://leetcode.com/problems/find-the-middle-index-in-array/
public class S01991
{
    public int FindMiddleIndex(int[] nums)
    {
        var sum = nums.Sum();
        var leftSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (leftSum == sum - leftSum - nums[i])
            {
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}