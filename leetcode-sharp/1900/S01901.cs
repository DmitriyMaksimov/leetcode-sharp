namespace leetcode_sharp;

// 1901. Find a Peak Element II
// https://leetcode.com/problems/find-a-peak-element-ii
public class S01901
{
    public int[] FindPeakGrid(int[][] mat)
    {
        var m = mat.Length;

        var low = 0;
        var high = m - 1;

        while (low < high)
        {
            var mid = low + (high - low) / 2;
            var maxIndex = FindIndexOfMaxElement(mat[mid]);

            if (mat[mid][maxIndex] < mat[mid + 1][maxIndex])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return [low, FindIndexOfMaxElement(mat[low])];
    }

    private static int FindIndexOfMaxElement(int[] arr)
    {
        return arr.Select((item, index) => (item, index)).Max().index;
    }
}
