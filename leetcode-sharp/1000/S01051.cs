namespace leetcode_sharp;

// 1051. Height Checker
// https://leetcode.com/problems/height-checker/
public class S01051
{
    public int HeightChecker(int[] heights)
    {
        var sorted = new int[heights.Length];
        Array.Copy(heights, sorted, heights.Length);
        Array.Sort(sorted);

        return heights.Where((height, i) => height != sorted[i]).Count();
    }
}