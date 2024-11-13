namespace leetcode_sharp;

// 1686. Stone Game VI
// https://leetcode.com/problems/stone-game-vi
public class S01686
{
    public int StoneGameVI(int[] aliceValues, int[] bobValues)
    {
        var list = new List<int[]>();
        var res = new int[2];
        var n = aliceValues.Length;

        for (var i = 0; i < n; ++i)
        {
            list.Add([-(aliceValues[i] + bobValues[i]), aliceValues[i], bobValues[i]]);
        }

        list.Sort((x, y) => x[0].CompareTo(y[0]));

        for (var i = 0; i < n; ++i)
        {
            res[i % 2] += list[i][1 + i % 2];
        }

        if (res[0] == res[1])
        {
            return 0;
        }

        return res[0] > res[1] ? 1 : -1;
    }
}
