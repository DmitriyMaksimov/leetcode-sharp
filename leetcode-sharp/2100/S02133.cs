namespace leetcode_sharp;

// 2133. Check if Every Row and Column Contains All Numbers
// https://leetcode.com/problems/check-if-every-row-and-column-contains-all-numbers/
public class S02133
{
    public bool CheckValid(int[][] matrix)
    {
        var n = matrix.Length;

        for (var i = 0; i < n; i++)
        {
            var hs = new HashSet<int>();
            var hs2 = new HashSet<int>();

            for (var j = 0; j < n; j++)
            {
                hs.Add(matrix[i][j]);
                hs2.Add(matrix[j][i]);
            }

            if (hs.Count != n || hs2.Count != n)
            {
                return false;
            }
        }

        return true;
    }
}