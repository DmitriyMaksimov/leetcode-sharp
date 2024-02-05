namespace leetcode_sharp;

// 
// https://leetcode.com/problems/type-of-triangle-ii
public class S03024
{
    public string TriangleType(int[] nums)
    {
        if (nums[0] + nums[1] <= nums[2] ||
            nums[0] + nums[2] <= nums[1] ||
            nums[1] + nums[2] <= nums[0])
        {
            return "none";
        }

        if (nums[0] == nums[1] && nums[1] == nums[2])
        {
            return "equilateral";
        }

        if (nums[0] != nums[1] && nums[1] != nums[2] && nums[0] != nums[2])
        {
            return "scalene";
        }
        
        if (nums[0] == nums[1] || nums[0] == nums[2] || nums[1] == nums[2])
        {
            return "isosceles";
        }

        return "none";
    }
}