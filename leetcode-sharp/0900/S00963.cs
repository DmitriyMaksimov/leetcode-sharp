namespace leetcode_sharp;

// 963. Minimum Area Rectangle II
// https://leetcode.com/problems/minimum-area-rectangle-ii
public class S00963
{
    public double MinAreaFreeRect(int[][] points)
    {
        var set = new HashSet<string>();
        foreach (var p in points)
        {
            set.Add($"{p[0]} {p[1]}");
        }

        var result = double.MaxValue;
        foreach (var p1 in points)
        {
            foreach (var p2 in points)
            {
                if (p1[0] == p2[0] && p1[1] == p2[1])
                {
                    continue;
                }

                foreach (var p3 in points)
                {
                    if (DistanceSquared(p1, p3) + DistanceSquared(p2, p3) != DistanceSquared(p1, p2))
                    {
                        continue;
                    }

                    var x = p1[0] + p2[0] - p3[0];
                    var y = p1[1] + p2[1] - p3[1];
                    if (!set.Contains($"{x} {y}"))
                    {
                        continue;
                    }

                    var area = Math.Sqrt(DistanceSquared(p1, p3)) * Math.Sqrt(DistanceSquared(p2, p3));
                    if (area != 0)
                    {
                        result = Math.Min(result, area);
                    }
                }
            }
        }

        return result == double.MaxValue ? 0 : result;
    }

    private static int DistanceSquared(int[] p1, int[] p2)
    {
        return (p1[0] - p2[0]) * (p1[0] - p2[0]) + (p1[1] - p2[1]) * (p1[1] - p2[1]);
    }
}
