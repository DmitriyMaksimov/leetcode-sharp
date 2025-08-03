namespace leetcode_sharp;

// 1329. Sort the Matrix Diagonally
// https://leetcode.com/problems/sort-the-matrix-diagonally
public class S01329
{
    private readonly HashSet<(int row, int cell)> _visited = [];

    public int[][] DiagonalSort(int[][] mat)
    {
        for (var r = 0; r < mat.Length; r++)
        {
            for (var c = 0; c < mat[r].Length; c++)
            {
                if (_visited.Contains((r, c)))
                {
                    break;
                }

                var diag = dfs(mat, r, c);
                diag.Sort(); // sort diagonal
                fill(mat, r, c, diag, 0);
            }
        }

        return mat;
    }

    private List<int> dfs(IReadOnlyList<int[]> mat, int r, int c)
    {
        if (r >= mat.Count || c >= mat[0].Length)
        {
            return [];
        }

        _visited.Add((r, c));
        
        List<int> result = [mat[r][c]];
        result.AddRange(dfs(mat, r + 1, c + 1));

        return result;
    }

    private static void fill(int[][] mat, int r, int c, IReadOnlyList<int> diag, int i)
    {
        if (r >= mat.Length || c >= mat[0].Length)
        {
            return;
        }

        mat[r][c] = diag[i];
        fill(mat, r + 1, c + 1, diag, i + 1);
    }
}