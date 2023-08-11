namespace leetcode_sharp;

// 287. Find the Duplicate Number
// https://leetcode.com/problems/find-the-duplicate-number/
public class S00287
{
    public int FindDuplicate(int[] nums)
    {
        var nextPos = nums[0];
        var pos = nums[0];
        var visited = 0;

        while (true)
        {
            if (nextPos < 0)
            {
                return Math.Abs(pos);
            }

            nums[visited] = -pos;
            pos = nextPos;
            visited = pos;
            nextPos = nums[pos];
        }
    }
}