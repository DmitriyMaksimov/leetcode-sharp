namespace leetcode_sharp;

// 822. Card Flipping Game
// https://leetcode.com/problems/card-flipping-game/description/
public class S00822
{
    public int Flipgame(int[] fronts, int[] backs)
    {
        var sameOnBothSides = new HashSet<int>();
        var n = fronts.Length;

        for (var i = 0; i < n; i++)
        {
            if (fronts[i] == backs[i])
            {
                sameOnBothSides.Add(fronts[i]);
            }
        }

        var min = int.MaxValue;

        for (var i = 0; i < n; i++)
        {
            if (!sameOnBothSides.Contains(backs[i]))
            {
                min = Math.Min(min, backs[i]);
            }

            if (!sameOnBothSides.Contains(fronts[i]))
            {
                min = Math.Min(min, fronts[i]);
            }
        }

        return min == int.MaxValue ? 0 : min;
    }
}