namespace leetcode_sharp;

// 3459. Length of Longest V-Shaped Diagonal Segment
// https://leetcode.com/problems/length-of-longest-v-shaped-diagonal-segment
public class S03459
{
    private readonly int[] _directions = [1, 1, -1, -1, 1];

    public int LenOfVDiagonal(int[][] grid)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;

        var memo = new int[rows][][];
        for (var i = 0; i < rows; i++)
        {
            memo[i] = new int[cols][];
            for (var j = 0; j < cols; j++)
            {
                memo[i][j] = new int[1 << 3];
            }
        }

        var result = 0;

        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                if (grid[row][col] != 1)
                {
                    continue;
                }

                int[] maxSteps = [rows - row, col + 1, row + 1, cols - col];

                for (var direction = 0; direction < _directions.Length - 1; direction++)
                {
                    if (maxSteps[direction] <= result)
                    {
                        continue;
                    }

                    result = Math.Max(
                        result,
                        Dfs(row, col, direction, canTurn: 1, target: 2, grid, memo) + 1
                    );
                }
            }
        }

        return result;
    }

    private int Dfs(int row, int col, int direction, int canTurn, int target, int[][] grid, int[][][] memo)
    {
        var (dx, dy) = (_directions[direction], _directions[direction + 1]);
        row += dx;
        col += dy;

        if (row < 0 || row >= grid.Length || col < 0 || col >= grid[row].Length || grid[row][col] != target)
        {
            return 0;
        }

        var mask = (direction << 1) | canTurn;
        if (memo[row][col][mask] > 0)
        {
            return memo[row][col][mask];
        }

        var result = Dfs(row, col, direction, canTurn, 2 - target, grid, memo);

        if (canTurn == 1)
        {
            int[] maxSteps = [grid.Length - row - 1, col, row, grid[row].Length - col - 1];
            var nextDir = (direction + 1) % 4;

            if (maxSteps[nextDir] > result)
            {
                result = Math.Max(
                    result,
                    Dfs(row, col, nextDir, canTurn: 0, target: 2 - target, grid, memo)
                );
            }
        }

        return memo[row][col][mask] = result + 1;
    }
}