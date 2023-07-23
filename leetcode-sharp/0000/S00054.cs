namespace leetcode_sharp;

// 54. Spiral Matrix
// https://leetcode.com/problems/spiral-matrix/
public class S00054
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var n = matrix.Length;
        var m = matrix[0].Length;
        var left = 0;
        var right = m - 1;
        var bottom = n - 1;
        var top = 0;
        var direction = 1;
        var result = new List<int>();

        while (left <= right && top <= bottom)
        {
            switch (direction)
            {
                case 1:
                {
                    for (var i = left; i <= right; i++)
                    {
                        result.Add(matrix[top][i]);
                    }

                    direction = 2;
                    top++;
                    break;
                }
                case 2:
                {
                    for (var i = top; i <= bottom; i++)
                    {
                        result.Add(matrix[i][right]);
                    }

                    direction = 3;
                    right--;
                    break;
                }
                case 3:
                {
                    for (var i = right; i >= left; i--)
                    {
                        result.Add(matrix[bottom][i]);
                    }

                    direction = 4;
                    bottom--;
                    break;
                }
                case 4:
                {
                    for (var i = bottom; i >= top; i--)
                    {
                        result.Add(matrix[i][left]);
                    }

                    direction = 1;
                    left++;
                    break;
                }
            }
        }

        return result;
    }
}