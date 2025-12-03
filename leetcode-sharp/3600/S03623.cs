namespace leetcode_sharp;

// 3623. Count Number of Trapezoids I
// https://leetcode.com/problems/count-number-of-trapezoids-i
public class S03623
{
    private const int Mod = 1_000_000_007;

    public int CountTrapezoids(int[][] points)
    {
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));

        var result = 0L;
        var total = 0L;

        var n = points.Length;

        for (var i = 0; i < n;)
        {
            var j = i + 1;

            while (j < n && points[i][1] == points[j][1])
            {
                j++;
            }

            long count = j - i;
            var lines = count * (count - 1) / 2;

            result = (result + total * lines) % Mod;
            total = (total + lines) % Mod;

            i = j;
        }

        return (int)result;
    }
}