namespace leetcode_sharp;

// 827. Making A Large Island
// https://leetcode.com/problems/making-a-large-island
public class S00827
{
    private int _n;

    public int LargestIsland(int[][] grid)
    {
        _n = grid.Length;
        var index = 3;
        var result = 0;
        var area = new Dictionary<int, int>();

        for (var x = 0; x < _n; ++x)
        {
            for (var y = 0; y < _n; ++y)
            {
                if (grid[x][y] == 1)
                {
                    area[index] = Dfs(grid, x, y, index);
                    result = Math.Max(result, area[index++]);
                }
            }
        }

        for (var x = 0; x < _n; ++x)
        {
            for (var y = 0; y < _n; ++y)
            {
                if (grid[x][y] == 0)
                {
                    var seen = new HashSet<int>();
                    var cur = 1;
                    foreach (var p in Move(x, y))
                    {
                        index = grid[p.Key][p.Value];
                        if (index > 1 && seen.Add(index))
                        {
                            cur += area[index];
                        }
                    }

                    result = Math.Max(result, cur);
                }
            }
        }

        return result;
    }

    private List<KeyValuePair<int, int>> Move(int x, int y)
    {
        var res = new List<KeyValuePair<int, int>>();

        if (IsValid(x, y + 1))
        {
            res.Add(new KeyValuePair<int, int>(x, y + 1));
        }

        if (IsValid(x, y - 1))
        {
            res.Add(new KeyValuePair<int, int>(x, y - 1));
        }

        if (IsValid(x + 1, y))
        {
            res.Add(new KeyValuePair<int, int>(x + 1, y));
        }

        if (IsValid(x - 1, y))
        {
            res.Add(new KeyValuePair<int, int>(x - 1, y));
        }

        return res;
    }

    private bool IsValid(int x, int y)
    {
        return x >= 0 && x < _n && y >= 0 && y < _n;
    }

    private int Dfs(int[][] grid, int x, int y, int index)
    {
        grid[x][y] = index;

        var area = Move(x, y).Where(p => grid[p.Key][p.Value] == 1).Sum(p => Dfs(grid, p.Key, p.Value, index));

        return area + 1;
    }
}
