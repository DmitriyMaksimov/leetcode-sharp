namespace leetcode_sharp;

// 2337. Move Pieces to Obtain a String
// https://leetcode.com/problems/move-pieces-to-obtain-a-string
public class S02337
{
    public bool CanChange(string start, string target)
    {
        var i = 0;
        var j = 0;
        var n = start.Length;

        for (; i < n || j < n; ++i, ++j)
        {
            while (i < n && start[i] == '_')
            {
                ++i;
            }

            while (j < n && target[j] == '_')
            {
                ++j;
            }

            if (i == n || j == n || start[i] != target[j] || (start[i] == 'L' && i < j) || (start[i] == 'R' && i > j))
            {
                break;
            }
        }

        return i == n && j == n;
    }
}
