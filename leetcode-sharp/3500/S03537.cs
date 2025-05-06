namespace leetcode_sharp;

// 3537. Fill a Special Grid
// https://leetcode.com/problems/fill-a-special-grid
public class S03537
{
    private int _val;

    public int[][] SpecialGrid(int n)
    {
        var size = 1 << n;
        var grid = new int[size][];
        for (var i = 0; i < size; i++)
        {
            grid[i] = new int[size];
        }

        Solve(grid, 0, 0, size);
        return grid;
    }

    private void Solve(int[][] grid, int r, int c, int size)
    {
        if (size == 1)
        {
            grid[r][c] = _val++;
            return;
        }

        var s = size / 2;
        Solve(grid, r, c + s, s); // top right
        Solve(grid, r + s, c + s, s); // bottom right
        Solve(grid, r + s, c, s); // bottom left
        Solve(grid, r, c, s); // top left
    }
}
