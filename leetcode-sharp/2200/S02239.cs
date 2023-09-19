namespace leetcode_sharp;

// 2239. Find Closest Number to Zero
// https://leetcode.com/problems/find-closest-number-to-zero/
public class S02239
{
    public int FindClosestNumber(int[] nums)
    {
        var min = int.MaxValue;
        var minAbs = int.MaxValue;

        foreach (var num in nums)
        {
            var abs = Math.Abs(num);
            if (abs < minAbs)
            {
                minAbs = abs;
                min = num;
            }
            else if (abs == minAbs)
            {
                min = Math.Max(min, num);
            }
        }

        return min;
    }
}