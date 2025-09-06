namespace leetcode_sharp;

// 3495. Minimum Operations to Make Array Elements Zero
// https://leetcode.com/problems/minimum-operations-to-make-array-elements-zero 
public class S03495
{
    public long MinOperations(int[][] queries)
    {
        var result = 0L;

        foreach (var query in queries)
        {
            long start = query[0];
            long end = query[1];
            var numberOfOperations = 0L;
            var prev = 1L;
            
            for (var d = 1L; d < 21; d++)
            {
                var cur = prev * 4;
                var l = Math.Max(start, prev);
                var r = Math.Min(end, cur - 1);
                if (r >= l)
                {
                    numberOfOperations += (r - l + 1) * d;
                }

                prev = cur;
            }

            result += (numberOfOperations + 1) / 2;
        }

        return result;
    }
}