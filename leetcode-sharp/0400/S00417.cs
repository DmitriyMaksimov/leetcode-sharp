namespace leetcode_sharp;

// 417. Pacific Atlantic Water Flow
// https://leetcode.com/problems/pacific-atlantic-water-flow
public class S00417
{
    private int _m;
    private int _n;
    private bool[][] _atlantic = null!;
    private bool[][] _pacific = null!;
    private readonly IList<List<int>> _result = new List<List<int>>();

    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        if (heights.Length == 0)
        {
            return [];
        }

        _m = heights.Length;
        _n = heights[0].Length;

        _atlantic = CreateVisitedArray(_m, _n);
        _pacific = CreateVisitedArray(_m, _n);

        for (var i = 0; i < _m; i++)
        {
            Dfs(heights, _pacific, i, 0);
            Dfs(heights, _atlantic, i, _n - 1);
        }

        for (var j = 0; j < _n; j++)
        {
            Dfs(heights, _pacific, 0, j);
            Dfs(heights, _atlantic, _m - 1, j);
        }

        return _result.ToArray();
    }

    private void Dfs(int[][] mat, bool[][] visited, int i, int j)
    {
        if (visited[i][j])
        {
            return;
        }

        visited[i][j] = true;

        if (_atlantic[i][j] && _pacific[i][j])
        {
            _result.Add([i, j]);
        }

        if (i + 1 < _m && mat[i + 1][j] >= mat[i][j])
        {
            Dfs(mat, visited, i + 1, j);
        }

        if (i - 1 >= 0 && mat[i - 1][j] >= mat[i][j])
        {
            Dfs(mat, visited, i - 1, j);
        }

        if (j + 1 < _n && mat[i][j + 1] >= mat[i][j])
        {
            Dfs(mat, visited, i, j + 1);
        }

        if (j - 1 >= 0 && mat[i][j - 1] >= mat[i][j])
        {
            Dfs(mat, visited, i, j - 1);
        }
    }

    private static bool[][] CreateVisitedArray(int rows, int cols)
    {
        var visited = new bool[rows][];

        for (var i = 0; i < rows; i++)
        {
            visited[i] = new bool[cols];
        }

        return visited;
    }
}
