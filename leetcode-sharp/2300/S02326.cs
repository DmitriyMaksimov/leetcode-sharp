namespace leetcode_sharp;

// 2326. Spiral Matrix IV
// https://leetcode.com/problems/spiral-matrix-iv/
public class S02326
{
    public int[][] SpiralMatrix(int m, int n, ListNode head)
    {
        var res = new int[m][];
        for (var i = 0; i < m; i++)
        {
            res[i] = new int[n];
            Array.Fill(res[i], -1);
        }

        var temp = head;
        var startRow = 0;
        var startCol = 0;
        var endRow = m - 1;
        var endCol = n - 1;

        while (temp != null)
        {
            for (var i = startCol; i <= endCol; i++)
            {
                if (temp == null)
                {
                    break;
                }

                res[startRow][i] = temp.val;
                temp = temp.next;
            }

            for (var i = startRow + 1; i <= endRow; i++)
            {
                if (temp == null)
                {
                    break;
                }

                res[i][endCol] = temp.val;
                temp = temp.next;
            }

            for (var i = endCol - 1; i >= startCol; i--)
            {
                if (temp == null)
                {
                    break;
                }

                res[endRow][i] = temp.val;
                temp = temp.next;
            }

            for (var i = endRow - 1; i > startRow; i--)
            {
                if (temp == null)
                {
                    break;
                }

                res[i][startCol] = temp.val;
                temp = temp.next;
            }

            startRow++;
            startCol++;
            endRow--;
            endCol--;
        }

        return res;
    }
}