namespace leetcode_sharp;

// 2221. Find Triangular Sum of an Array
// https://leetcode.com/problems/find-triangular-sum-of-an-array
public class S02221
{
    public int TriangularSum(int[] nums)
    {
        var n = nums.Length;
        
        for (var i = n - 1; i >= 1; i--)
        {
            for (var j = 0; j < i; j++)
            {
                nums[j] = (nums[j] + nums[j + 1]) % 10;
            }
        }

        return nums[0];
    }
}