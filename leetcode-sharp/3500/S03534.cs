using System.Numerics;

namespace leetcode_sharp;

// 3534. Path Existence Queries in a Graph II
// https://leetcode.com/problems/path-existence-queries-in-a-graph-ii
public class S03534
{
    public int[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries)
    {
        var maxLevel = BitOperations.Log2((uint)n) + 2;
        var up = new int[maxLevel][];
        for (var i = 0; i < maxLevel; i++)
        {
            up[i] = new int[n];
        }

        var position = new int[n];
        var sorted = new (int Value, int Index)[n];

        for (var i = 0; i < n; i++)
        {
            sorted[i] = (nums[i], i);
        }

        Array.Sort(sorted, (a, b) => a.Value.CompareTo(b.Value));

        for (var i = 0; i < n; i++)
        {
            position[sorted[i].Index] = i;
        }

        var right = 0;
        for (var left = 0; left < n; left++)
        {
            while (right + 1 < n && sorted[right + 1].Value - sorted[left].Value <= maxDiff)
            {
                right++;
            }

            up[0][left] = right;
        }

        for (var level = 1; level < maxLevel; level++)
        {
            for (var i = 0; i < n; i++)
            {
                up[level][i] = up[level - 1][up[level - 1][i]];
            }
        }

        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var u = position[queries[i][0]];
            var v = position[queries[i][1]];

            if (u > v)
            {
                (u, v) = (v, u);
            }

            result[i] = CountSteps(u, v, maxLevel, up);
        }

        return result;
    }

    private static int CountSteps(int from, int to, int maxLevel, int[][] up)
    {
        if (from == to)
        {
            return 0;
        }

        if (up[0][from] >= to)
        {
            return 1;
        }

        if (up[maxLevel - 1][from] < to)
        {
            return -1;
        }

        var steps = 0;

        for (var level = maxLevel - 1; level >= 0; level--)
        {
            if (up[level][from] < to)
            {
                steps += 1 << level;
                from = up[level][from];
            }
        }

        return steps + 1;
    }
}