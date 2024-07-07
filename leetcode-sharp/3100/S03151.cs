namespace leetcode_sharp;

// 3151. Special Array I
// https://leetcode.com/problems/special-array-i
public class S03151
{
    public bool IsArraySpecial(int[] nums)
    {
        var previousParity = nums[0] % 2;

        for (var i = 1; i < nums.Length; i++)
        {
            var currentParity = nums[i] % 2;

            if (currentParity == previousParity)
            {
                return false;
            }

            previousParity = currentParity;
        }

        return true;
    }
}