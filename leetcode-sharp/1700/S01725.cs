namespace leetcode_sharp;

// 1725. Number Of Rectangles That Can Form The Largest Square
// https://leetcode.com/problems/number-of-rectangles-that-can-form-the-largest-square/
public class S01725
{
    public int CountGoodRectangles(int[][] rectangles)
    {
        var maxLen = 0;
        var maxLenCount = 0;

        foreach (var rectangle in rectangles)
        {
            var len = Math.Min(rectangle[0], rectangle[1]);

            if (len > maxLen)
            {
                maxLen = len;
                maxLenCount = 1;
            }
            else if (len == maxLen)
            {
                maxLenCount++;
            }
        }

        return maxLenCount;
    }
}