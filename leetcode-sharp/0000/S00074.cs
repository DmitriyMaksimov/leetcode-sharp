namespace leetcode_sharp;

// 74. Search a 2D Matrix
// https://leetcode.com/problems/search-a-2d-matrix/
public class S00074
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        foreach (var row in matrix)
        {
            if (Array.BinarySearch(row, target) >= 0)
            {
                return true;
            }
        }

        return false;
    }
}