namespace leetcode_sharp;

// 944. Delete Columns to Make Sorted
// https://leetcode.com/problems/delete-columns-to-make-sorted/
public class S00944
{
    public int MinDeletionSize(string[] strs)
    {
        var count = 0;
        var length = strs[0].Length;

        for (var j = 0; j < length; j++)
        {
            for (var i = 1; i < strs.Length; i++)
            {
                if (strs[i][j] < strs[i - 1][j])
                {
                    ++count;
                    break;
                }
            }
        }

        return count;
    }
}