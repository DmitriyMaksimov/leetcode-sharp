namespace leetcode_sharp;

// 1351. Count Negative Numbers in a Sorted Matrix
// https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/
public class S01351
{
    public int CountNegatives(int[][] grid)
    {
        return grid.Sum(row => row.Count(n => n < 0));
    }
}