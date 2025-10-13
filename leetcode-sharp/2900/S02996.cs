namespace leetcode_sharp;

// 2996. Smallest Missing Integer Greater Than Sequential Prefix Sum
// https://leetcode.com/problems/smallest-missing-integer-greater-than-sequential-prefix-sum
public class S02996
{
    public int MissingInteger(int[] nums)
    {
        var countSum = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] + 1 != nums[i])
            {
                break;
            }

            countSum += nums[i];
        }

        foreach (var num in nums.Order())
        {
            if (countSum == num)
            {
                countSum++;
            }
        }

        return countSum;
    }
}