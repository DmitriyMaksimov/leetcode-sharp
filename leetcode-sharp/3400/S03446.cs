namespace leetcode_sharp;

// 3446. Sort Matrix by Diagonals
// https://leetcode.com/problems/sort-matrix-by-diagonals
public class S03446
{
    public int[][] SortMatrix(int[][] grid)
    {
        Dictionary<int, List<int>> diag = [];

        for (var i = 0; i < grid.Length; ++i)
        {
            for (var j = 0; j < grid[i].Length; ++j)
            {
                var key = i - j;
                diag.TryAdd(key, []);
                diag[key].Add(grid[i][j]);
            }
        }

        foreach (var key in diag.Keys)
        {
            if (key >= 0)
            {
                diag[key].Sort();
            }
            else
            {
                diag[key].Sort((a, b) => b.CompareTo(a));
            }
        }

        for (var i = 0; i < grid.Length; ++i)
        {
            for (var j = 0; j < grid[i].Length; ++j)
            {
                var key = i - j;
                grid[i][j] = diag[key][diag[key].Count - 1];
                diag[key].RemoveAt(diag[key].Count - 1);
            }
        }

        return grid;
    }
}
