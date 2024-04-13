namespace leetcode_sharp;

// 85. Maximal Rectangle
// https://leetcode.com/problems/maximal-rectangle
public class S00085
{
    public int MaximalRectangle(char[][] matrix)
    {
        var r = matrix.Length;
        if (r == 0) return 0;
        var c = matrix[0].Length;
        var area = 0;
        var left = new int[c];
        var right = new int[c];
        var height = new int[c];
        
        Array.Fill(right, c);

        for (var i = 0; i < r; i++)
        {
            var cur = 0;
            for (var j = 0; j < c; j++)
            {
                if (matrix[i][j] == '0')
                {
                    height[j] = left[j] = 0;
                    cur = j + 1;
                }
                else
                {
                    left[j] = Math.Max(left[j], cur);
                    height[j]++;
                }
            }

            cur = c;
            for (var j = c - 1; j >= 0; j--)
            {
                if (matrix[i][j] == '0') cur = j;
                right[j] = matrix[i][j] == '0' ? c : Math.Min(right[j], cur);
                area = Math.Max(height[j] * (right[j] - left[j]), area);
            }
        }

        return area;
    }
}