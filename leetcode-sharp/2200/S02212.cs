namespace leetcode_sharp;

// 2212. Maximum Points in an Archery Competition
// https://leetcode.com/problems/maximum-points-in-an-archery-competition
public class S02212
{
    private List<int> _result = [];
    private int _target;
    private int[] _aliceArrows = null!;

    public int[] MaximumBobPoints(int numArrows, int[] aliceArrows)
    {
        var res = new int[12];
        _aliceArrows = aliceArrows;
        Backtrack(11, numArrows, 0, res);
        return _result.ToArray();
    }

    private void Backtrack(int n, int numArrows, int sum, int[] res)
    {
        if (n == -1 || numArrows <= 0)
        {
            if (sum > _target)
            {
                _target = sum;
                var temp = new int[12];
                Array.Copy(res, temp, 12);

                if (numArrows > 0)
                {
                    temp[0] += numArrows;
                }

                _result = [..temp];
            }

            return;
        }

        var req = _aliceArrows[n] + 1;

        if (req <= numArrows)
        {
            res[n] = req;
            Backtrack(n - 1, numArrows - req, sum + n, res);
            res[n] = 0;
        }

        Backtrack(n - 1, numArrows, sum, res);
    }
}
