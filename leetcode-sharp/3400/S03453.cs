namespace leetcode_sharp;

// 3453. Separate Squares I
// https://leetcode.com/problems/separate-squares-i
public class S03453
{
    public double SeparateSquares(int[][] squares)
    {
        var totalArea = 0.0;
        var lo = double.MaxValue;
        var hi = double.MinValue;

        foreach (var sq in squares)
        {
            double y = sq[1];
            double l = sq[2];
            totalArea += l * l;
            lo = Math.Min(lo, y);
            hi = Math.Max(hi, y + l);
        }

        var target = totalArea / 2.0;

        for (var iter = 0; iter < 100; iter++)
        {
            var mid = lo + (hi - lo) * 0.5;
            var below = AreaBelow(mid, squares);

            if (below < target)
            {
                lo = mid;
            }
            else
            {
                hi = mid;
            }
        }

        return lo;
    }

    private static double AreaBelow(double h, int[][] squares)
    {
        var sum = 0.0;

        foreach (var sq in squares)
        {
            double y = sq[1];
            double l = sq[2];

            if (h <= y)
            {
                // contributes 0
            }
            else if (h >= y + l)
            {
                sum += l * l;
            }
            else
            {
                sum += l * (h - y);
            }
        }

        return sum;
    }
}