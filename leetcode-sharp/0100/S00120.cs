namespace leetcode_sharp;

// 120. Triangle
// https://leetcode.com/problems/triangle/
public class S00120
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        // Start with last - 1 row
        var row = triangle.Count - 1 - 1;

        while (row >= 0)
        {
            for (var i = 0; i < triangle[row].Count; ++i)
            {
                triangle[row][i] += Math.Min(triangle[row + 1][i], triangle[row + 1][i + 1]);
            }
            --row;
        }
        
        return triangle[0][0];
    }
}