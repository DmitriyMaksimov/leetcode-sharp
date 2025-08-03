namespace leetcode_sharp;

// 149. Max Points on a Line
// https://leetcode.com/problems/max-points-on-a-line/
public class S00149
{
    public int MaxPoints(int[][] points)
    {
        if (points.Length <= 1)
        {
            return points.Length;
        }
        
        var result = 0;

        for (var i = 0; i < points.Length; i++)
        {
            var counts = new Dictionary<double, int>();
            
            for (var j = i + 1; j < points.Length; j++)
            {
                if (points[i][0] == points[j][0])
                {
                    // special case - x coordinates the same => can't calculate slope - use max double
                    counts[double.MaxValue] = counts.GetValueOrDefault(double.MaxValue, 0) + 1;
                }
                else
                {
                    var slope = (double)(points[i][1] - points[j][1]) / (points[i][0] - points[j][0]);

                    counts[slope] = counts.GetValueOrDefault(slope, 0) + 1;
                }
            }

            if (counts.Count != 0)
            {
                result = Math.Max(result, counts.Values.Max() + 1);
            }
        }
        
        return result;
    }
}