namespace leetcode_sharp;

// 3963. Create Grid With Exactly One Path
// https://leetcode.com/problems/create-grid-with-exactly-one-path
public class S03963
{
    public string[] CreateGrid(int m, int n)
    {
        var grid = Enumerable.Repeat(new string('#', n), m).ToArray();

        for (var i = 0; i < n; i++)
        {
            var row = grid[0].ToCharArray();
            row[i] = '.';
            grid[0] = new string(row);
        }

        for (var j = 0; j < m; j++)
        {
            var row = grid[j].ToCharArray();
            row[n - 1] = '.';
            grid[j] = new string(row);
        }

        return grid;
    }
}