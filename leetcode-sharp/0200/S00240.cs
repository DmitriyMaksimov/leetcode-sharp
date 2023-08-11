namespace leetcode_sharp;

// 240. Search a 2D Matrix II
// https://leetcode.com/problems/search-a-2d-matrix-ii/
public class S00240
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        return matrix.Any(row => Array.BinarySearch(row, target) >= 0);
    }
}