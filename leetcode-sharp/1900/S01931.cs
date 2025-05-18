namespace leetcode_sharp;

// 1931. Painting a Grid With Three Different Colors
// https://leetcode.com/problems/painting-a-grid-with-three-different-colors
public class S01931
{
    private const int Mod = 1_000_000_007;
    private readonly Dictionary<(int, int), int> _memo = [];

    public int ColorTheGrid(int m, int n)
    {
        var possibleColumns = GenerateColumns(0, 0, m);

        return Dfs(0, 0, m, n, possibleColumns);
    }

    private static List<int> GenerateColumns(int previous, int count, int m)
    {
        if (count == m)
        {
            return [0];
        }

        List<int> columns = [];
        int[] colors = [1, 2, 4];

        foreach (var color in colors)
        {
            if (color == previous)
            {
                continue;
            }

            var suffixes = GenerateColumns(color, count + 1, m);
            columns.AddRange(suffixes.Select(suffix => (color << (count * 3)) | suffix));
        }

        return columns;
    }

    private int Dfs(int prevColumn, int columnIndex, int m, int n, List<int> possibleColumns)
    {
        var key = (prevColumn, columnIndex);
        if (_memo.TryGetValue(key, out var value))
        {
            return value;
        }

        if (columnIndex >= n)
        {
            return 1;
        }

        long result = 0;

        foreach (var column in possibleColumns)
        {
            if ((prevColumn & column) != 0)
            {
                continue;
            }

            result = (result + Dfs(column, columnIndex + 1, m, n, possibleColumns)) % Mod;
        }

        return _memo[key] = (int)result;
    }
}
