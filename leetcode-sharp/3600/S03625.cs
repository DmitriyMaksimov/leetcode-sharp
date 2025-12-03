namespace leetcode_sharp;

// 3625. Count Number of Trapezoids II
// https://leetcode.com/problems/count-number-of-trapezoids-ii
public class S03625
{
    public int CountTrapezoids(int[][] points)
    {
        var t = new Dictionary<int, Dictionary<int, int>>();
        var v = new Dictionary<int, Dictionary<int, int>>();
        var n = points.Length;

        for (var i = 0; i < n; i++)
        {
            var x1 = points[i][0];
            var y1 = points[i][1];

            for (var j = i + 1; j < n; j++)
            {
                var x2 = points[j][0];
                var y2 = points[j][1];
                var dx = x2 - x1;
                var dy = y2 - y1;

                if (dx < 0 || (dx == 0 && dy < 0))
                {
                    dx = -dx;
                    dy = -dy;
                }

                var g = Gcd(dx, Math.Abs(dy));
                var sx = dx / g;
                var sy = dy / g;

                var des = sx * y1 - sy * x1;

                var key1 = (sx << 12) | (sy + 2000);
                var key2 = (dx << 12) | (dy + 2000);

                Add(t, key1, des);
                Add(v, key2, des);
            }
        }

        return Count(t) - Count(v) / 2;
    }

    private static void Add(Dictionary<int, Dictionary<int, int>> dictionary, int key, int des)
    {
        if (!dictionary.ContainsKey(key))
        {
            dictionary[key] = new Dictionary<int, int>();
        }

        if (!dictionary[key].ContainsKey(des))
        {
            dictionary[key][des] = 0;
        }

        dictionary[key][des]++;
    }

    private static int Count(Dictionary<int, Dictionary<int, int>> map)
    {
        var result = 0L;

        foreach (var inner in map.Values)
        {
            var total = inner.Values.Aggregate<int, long>(0, (current, val) => current + val);

            var rem = total;
            foreach (var val in inner.Values)
            {
                rem -= val;
                result += val * rem;
            }
        }

        return (int)result;
    }

    private static int Gcd(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            var tmp = a % b;
            a = b;
            b = tmp;
        }

        return a;
    }
}