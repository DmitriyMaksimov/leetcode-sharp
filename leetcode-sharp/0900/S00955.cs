namespace leetcode_sharp;

// 955. Delete Columns to Make Sorted II
// https://leetcode.com/problems/delete-columns-to-make-sorted-ii
public class S00955
{
    public int MinDeletionSize(string[] strs)
    {
        var n = strs.Length;
        var sorted = new bool[n - 1];
        var deletions = 0;

        for (var col = 0; col < strs[0].Length; col++)
        {
            var mustDelete = false;

            for (var i = 0; i < n - 1; i++)
            {
                if (!sorted[i] && strs[i][col] > strs[i + 1][col])
                {
                    mustDelete = true;
                    break;
                }
            }

            if (mustDelete)
            {
                deletions++;
                continue;
            }

            for (var i = 0; i < n - 1; i++)
            {
                if (!sorted[i] && strs[i][col] < strs[i + 1][col])
                {
                    sorted[i] = true;
                }
            }
        }

        return deletions;
    }
}