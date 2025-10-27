namespace leetcode_sharp;

// 260. Single Number III
// https://leetcode.com/problems/single-number-iii/description
public class S00260
{
    public int[] SingleNumber(int[] nums)
    {
        var diff = nums.Aggregate(0, (current, num) => current ^ num);

        diff &= -diff;

        var rets = new[] { 0, 0 };

        foreach (var num in nums)
        {
            if ((num & diff) == 0)
            {
                rets[0] ^= num;
            }
            else
            {
                rets[1] ^= num;
            }
        }

        return rets;
    }
}