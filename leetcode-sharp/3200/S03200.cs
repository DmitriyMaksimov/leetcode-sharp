namespace leetcode_sharp;

// 3200. Maximum Height of a Triangle
// https://leetcode.com/problems/maximum-height-of-a-triangle
public class S03200
{
    public int MaxHeightOfTriangle(int red, int blue)
    {
        return Math.Max(FindHeight([red, blue]), FindHeight([blue, red]));
    }

    private static int FindHeight(int[] nums)
    {
        var height = 0;
        var required = 1;
        var turn = 0;
        
        while (nums[turn] >= required)
        {
            nums[turn] -= required;
            turn = turn == 0 ? 1 : 0;
            ++required;
            ++height;
        }

        return height;
    }
}