namespace leetcode_sharp;

// 806. Number of Lines To Write String
// https://leetcode.com/problems/number-of-lines-to-write-string/
public class S00806
{
    public int[] NumberOfLines(int[] widths, string s)
    {
        var lines = 1;
        var width = 0;
        const int maxPixels = 100;

        foreach (var c in s)
        {
            var w = widths[c - 'a'];

            if (width + w > maxPixels)
            {
                lines++;
                width = w;
            }
            else
            {
                width += w;
            }
        }

        return new[] {lines, width};
    }
}