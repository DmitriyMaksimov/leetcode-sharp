namespace leetcode_sharp;

// 2679. Sum in a Matrix
// https://leetcode.com/problems/sum-in-a-matrix
public class S02679
{
    public int MatrixSum(int[][] nums)
    {
        return nums
            .Select(row => row.OrderDescending())
            .Aggregate(new int[nums[0].Length], (sum, row) =>
                sum.Zip(row, Math.Max).ToArray()
            )
            .Sum();
    }
}
