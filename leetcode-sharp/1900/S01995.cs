namespace leetcode_sharp;

// 1995. Count Special Quadruplets
// https://leetcode.com/problems/count-special-quadruplets/
public class S01995
{
    public int CountQuadruplets(int[] nums)
    {
        var result = 0;
        
        for (var i = 0; i < nums.Length - 3; i++)
        {
            for (var j = i + 1; j < nums.Length - 2; j++)
            {
                for (var k = j + 1; k < nums.Length - 1; k++)
                {
                    for (var l = k + 1; l < nums.Length; l++)
                    {
                        if (nums[i] + nums[j] + nums[k] == nums[l]) result++;
                    }
                }
            }
        }

        return result;
    }
}