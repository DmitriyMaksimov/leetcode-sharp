namespace leetcode_sharp;

// 3417. Zigzag Grid Traversal With Skip
// https://leetcode.com/problems/zigzag-grid-traversal-with-skip
public class S03417
{
    public IList<int> ZigzagTraversal(int[][] grid)
    {
        var m = grid[0].Length;
        var skip = false;
        var result = new List<int>();

        for (var row = 0; row < grid.Length; row++)
        {
            for (var i = 0; i < m; i++)
            {
                if (!skip)
                {
                    result.Add(grid[row][row % 2 == 0 ? i : m - 1 - i]);
                }

                skip = !skip;
            }
        }

        return result;
    }
}
