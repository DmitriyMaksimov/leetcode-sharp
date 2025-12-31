namespace leetcode_sharp;

// 3637. Trionic Array I
// https://leetcode.com/problems/trionic-array-i
public class S03637
{
    public bool IsTrionic(int[] nums)
    {
        var n = nums.Length;

        if (n < 4) return false;

        var i = 0;
        while (i < n - 2 && nums[i] < nums[i + 1])
        {
            i++;
        }

        if (i == 0) return false;

        var p = i;

        while (i < n - 1 && nums[i] > nums[i + 1])
        {
            i++;
        }

        if (i == p || i == n - 1) return false;

        while (i < n - 1 && nums[i] < nums[i + 1])
        {
            i++;
        }

        return i == n - 1;
    }
}