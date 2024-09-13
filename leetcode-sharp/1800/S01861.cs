namespace leetcode_sharp;

// 1861. Rotating the Box
// https://leetcode.com/problems/rotating-the-box
public class S01861
{
    private const char Empty = '.';
    private const char Obstacle = '*';

    public char[][] RotateTheBox(char[][] box)
    {
        var m = box.Length;
        var n = box[0].Length;
        var res = new char[n][];

        for (var i = 0; i < n; i++)
        {
            res[i] = new char[m];
        }

        for (var i = 0; i < m; ++i)
        {
            for (int j = n - 1, k = n - 1; j >= 0; --j)
            {
                res[j][m - i - 1] = Empty;

                if (box[i][j] != Empty)
                {
                    k = box[i][j] == Obstacle ? j : k;
                    res[k--][m - i - 1] = box[i][j];
                }
            }
        }

        return res;
    }
}
