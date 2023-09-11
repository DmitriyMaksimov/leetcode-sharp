namespace leetcode_sharp;

// 1893. Check if All the Integers in a Range Are Covered
// https://leetcode.com/problems/check-if-all-the-integers-in-a-range-are-covered/
public class S01893
{
    public bool IsCovered(int[][] ranges, int left, int right)
    {
        var covered = new bool[51];

        foreach (var range in ranges)
        {
            for (var i = range[0]; i <= range[1]; i++)
            {
                covered[i] = true;
            }
        }

        for (var i = left; i <= right; i++)
        {
            if (!covered[i])
            {
                return false;
            }
        }

        return true;
    }
}