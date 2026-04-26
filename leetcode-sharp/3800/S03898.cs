namespace leetcode_sharp;

// 3898. Find the Degree of Each Vertex
// https://leetcode.com/problems/find-the-degree-of-each-vertex
public class S03898
{
    public int[] FindDegrees(int[][] matrix)
    {
        var result = new int[matrix.Length];

        for (var i = 0; i < matrix.Length; i++)
        {
            result[i] = matrix[i].Sum();
        }
        
        return result;
    }
}