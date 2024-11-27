namespace leetcode_sharp;

// 2201. Count Artifacts That Can Be Extracted
// https://leetcode.com/problems/count-artifacts-that-can-be-extracted
public class S02201
{
    public int DigArtifacts(int n, int[][] artifacts, int[][] dig)
    {
        var grid = new int[n, n];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                grid[i, j] = 1;
            }
        }

        foreach (var d in dig)
        {
            grid[d[0], d[1]] = 0;
        }

        var prefixSum = new int[n + 1, n + 1];

        for (var i = 0; i <= n; i++)
        {
            prefixSum[i, 0] = 0;
            prefixSum[0, i] = 0;
        }

        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j <= n; j++)
            {
                prefixSum[i, j] = prefixSum[i - 1, j] + prefixSum[i, j - 1] - prefixSum[i - 1, j - 1] + grid[i - 1, j - 1];
            }
        }

        var result = 0;

        foreach (var artifact in artifacts)
        {
            var r1 = artifact[0];
            var c1 = artifact[1];
            var r2 = artifact[2];
            var c2 = artifact[3];

            var sum = prefixSum[r2 + 1, c2 + 1] - prefixSum[r1, c2 + 1] - prefixSum[r2 + 1, c1] + prefixSum[r1, c1];

            if (sum == 0)
            {
                result++;
            }
        }

        return result;
    }
}
