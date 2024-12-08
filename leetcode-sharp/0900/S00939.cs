namespace leetcode_sharp;

// 939. Minimum Area Rectangle
// https://leetcode.com/problems/minimum-area-rectangle
public class S00939
{
    public int MinAreaRect(int[][] points)
    {
        var dictionary = new Dictionary<int, HashSet<int>>();
        var result = int.MaxValue;

        foreach (var point in points)
        {
            var x = point[0];
            var y = point[1];
            dictionary.TryAdd(x, []);
            dictionary[x].Add(y);
        }

        for (var i = 0; i < points.Length - 1; i++)
        {
            for (var j = i + 1; j < points.Length; j++)
            {
                var x1 = points[i][0];
                var y1 = points[i][1];
                var x2 = points[j][0];
                var y2 = points[j][1];

                if (x1 == x2 || y1 == y2)
                {
                    continue;
                }

                if (dictionary[x1].Contains(y2) && dictionary[x2].Contains(y1))
                {
                    var area = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);
                    result = Math.Min(result, area);
                }
            }
        }

        return result == int.MaxValue ? 0 : result;
    }
}
