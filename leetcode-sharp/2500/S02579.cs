namespace leetcode_sharp;

// 2579. Count Total Number of Colored Cells
// https://leetcode.com/problems/count-total-number-of-colored-cells
public class S02579
{
    public long ColoredCells(int n)
    {
        return 1L * n * n + 1L * (n - 1) * (n - 1);
    }
}
