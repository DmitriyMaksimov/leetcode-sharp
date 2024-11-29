namespace leetcode_sharp;

// 2397. Maximum Rows Covered by Columns
// https://leetcode.com/problems/maximum-rows-covered-by-columns
public class S02397
{
    public int MaximumRows(int[][] matrix, int numSelect)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var ans = int.MinValue;

        var combinations = GetCombinations(Enumerable.Range(0, n).ToList(), n - numSelect);

        foreach (var comb in combinations)
        {
            var excludeColumns = comb.ToHashSet();

            var uncoveredRowCount = 0;

            for (var row = 0; row < m; row++)
            {
                var uncovered = false;

                for (var col = 0; col < n; col++)
                {
                    if (matrix[row][col] == 1 && excludeColumns.Contains(col))
                    {
                        uncovered = true;
                        break;
                    }
                }

                if (uncovered)
                {
                    uncoveredRowCount++;
                }
            }

            ans = Math.Max(ans, m - uncoveredRowCount);
        }

        return ans;
    }

    private static IEnumerable<IEnumerable<int>> GetCombinations(List<int> list, int k)
    {
        if (k == 0)
        {
            yield return new List<int>();
            yield break;
        }

        if (list.Count == 0)
        {
            yield break;
        }

        var head = list[0];
        var rest = list.Skip(1).ToList();

        foreach (var combination in GetCombinations(rest, k - 1))
        {
            yield return new List<int> { head }.Concat(combination);
        }

        foreach (var combination in GetCombinations(rest, k))
        {
            yield return combination;
        }
    }
}
