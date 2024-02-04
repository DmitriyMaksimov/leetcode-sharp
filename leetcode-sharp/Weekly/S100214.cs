namespace leetcode_sharp;

// 100214. Ant on the Boundary
// https://leetcode.com/contest/weekly-contest-383/problems/ant-on-the-boundary
public class S100214
{
    public int ReturnToBoundaryCount(int[] nums)
    {
        var result = 0;
        var currentPosition = 0;
        
        foreach (var num in nums)
        {
            currentPosition += num;
            if (currentPosition == 0)
            {
                ++result;
            }
        }
        
        return result;
    }
}