namespace leetcode_sharp;

// 1144. Decrease Elements To Make Array Zigzag
// https://leetcode.com/problems/decrease-elements-to-make-array-zigzag/description/
public class S01144
{
    public int MovesToMakeZigzag(int[] nums)
    {
        const int maxIndex = 1000;
        var evenIndexMoves = 0;
        var oddIndexMoves = 0;
        var n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            var left = i > 0 ? nums[i - 1] : maxIndex;
            var right = i + 1 < n ? nums[i + 1] : maxIndex;
            var minNeighbor = Math.Min(left, right);

            if (minNeighbor <= nums[i])
            {
                if (i % 2 == 0)
                {
                    evenIndexMoves += nums[i] - minNeighbor + 1;
                }
                else
                {
                    oddIndexMoves += nums[i] - minNeighbor + 1;
                }
            }
        }

        return Math.Min(evenIndexMoves, oddIndexMoves);
    }
}
