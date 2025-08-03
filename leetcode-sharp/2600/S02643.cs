namespace leetcode_sharp;

// 2643. Row With Maximum Ones
// https://leetcode.com/problems/row-with-maximum-ones/
public class S02643
{
    public int[] RowAndMaximumOnes(int[][] mat)
    {
        var rows = mat.Length;
        var cols = mat[0].Length;

        var maxOnes = -1;
        var rowWithMaxOnes = -1;

        for (var row = 0; row < rows; ++row)
        {
            var ones = 0;
            
            for (var col = 0; col < cols; ++col)
            {
                if (mat[row][col] == 1)
                {
                    ++ones;
                }
            }

            if (ones > maxOnes)
            {
                maxOnes = ones;
                rowWithMaxOnes = row;
            }
        }
        
        return [rowWithMaxOnes, maxOnes];
    }
}