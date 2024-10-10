namespace leetcode_sharp;

// 378. Kth Smallest Element in a Sorted Matrix
// https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix
public class S00378
{
    public int KthSmallest(int[][] matrix, int k)
    {
        var n = matrix.Length;
        var lo = matrix[0][0];
        var hi = matrix[n - 1][n - 1];

        while (lo <= hi)
        {
            var mid = lo + (hi - lo) / 2;
            var count = CountLessOrEqual(mid, matrix);

            if (count < k)
            {
                lo = mid + 1;
            }
            else
            {
                hi = mid - 1;
            }
        }

        return lo;
    }

    private static int CountLessOrEqual(int target, int[][] matrix)
    {
        var n = matrix.Length;
        var i = n - 1;
        var j = 0;
        var cnt = 0;

        while (i >= 0 && j < n)
        {
            if (matrix[i][j] > target)
            {
                i--;
            }
            else
            {
                cnt += i + 1;
                j++;
            }
        }

        return cnt;
    }
}
