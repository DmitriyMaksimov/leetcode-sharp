namespace leetcode_sharp;

// 3661. Maximum Walls Destroyed by Robots
// https://leetcode.com/problems/maximum-walls-destroyed-by-robots
public class S03661
{
    private const long Max = 1_000_000_000;
    private const long Min = 1;

    public int MaxWalls(int[] robots, int[] distance, int[] walls)
    {
        var n = robots.Length;

        var robotPositions = new List<(int pos, int dist)>();
        for (var i = 0; i < n; i++)
        {
            robotPositions.Add((robots[i], distance[i]));
        }

        robotPositions.Sort((a, b) => a.pos.CompareTo(b.pos));
        var wallList = new List<int>(walls);
        wallList.Sort();

        var ranges = new List<(long left, long right)>(n);

        for (var i = 0; i < n; i++)
        {
            long pos = robotPositions[i].pos;
            long dist = robotPositions[i].dist;

            var minBound = (i == 0) ? Min : robotPositions[i - 1].pos + 1;
            var maxBound = (i == n - 1) ? Max : robotPositions[i + 1].pos - 1;

            var left = Math.Max(pos - dist, minBound);
            var right = Math.Min(pos + dist, maxBound);

            ranges.Add((left, right));
        }

        var dp = new int[n, 2];
        for (var i = 0; i < n; i++)
        {
            dp[i, 0] = dp[i, 1] = -1;
        }

        return Solve(wallList, robotPositions, ranges, dp, 0, 0);
    }

    private int CountInRange(List<int> walls, long low, long high)
    {
        if (low > high)
        {
            return 0;
        }

        var left = LowerBound(walls, (int)low);
        var right = UpperBound(walls, (int)high);

        return right - left;
    }

    private static int LowerBound(List<int> list, int target)
    {
        int l = 0, r = list.Count;
        while (l < r)
        {
            var mid = l + (r - l) / 2;
            if (list[mid] < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }

        return l;
    }

    private static int UpperBound(List<int> list, int target)
    {
        int l = 0, r = list.Count;
        while (l < r)
        {
            var mid = l + (r - l) / 2;
            if (list[mid] <= target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }

        return l;
    }

    private int Solve(List<int> walls, List<(int pos, int dist)> robots, List<(long left, long right)> ranges, int[,] dp, int i, int dir)
    {
        if (i == ranges.Count)
        {
            return 0;
        }

        if (dp[i, dir] != -1)
        {
            return dp[i, dir];
        }

        var left = ranges[i].left;

        if (dir == 1)
        {
            left = Math.Max(left, ranges[i - 1].right + 1);
        }

        var opt1 = CountInRange(walls, left, robots[i].pos) + Solve(walls, robots, ranges, dp, i + 1, 0);
        var opt2 = CountInRange(walls, robots[i].pos, ranges[i].right) + Solve(walls, robots, ranges, dp, i + 1, 1);

        return dp[i, dir] = Math.Max(opt1, opt2);
    }
}