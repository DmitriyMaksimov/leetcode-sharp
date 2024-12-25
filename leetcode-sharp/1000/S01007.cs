namespace leetcode_sharp;

// 1007. Minimum Domino Rotations For Equal Row
// https://leetcode.com/problems/minimum-domino-rotations-for-equal-row
public class S01007
{
    public int MinDominoRotations(int[] tops, int[] bottoms)
    {
        const int maxPoint = 7;

        var countTops = new int[maxPoint];
        var countBottoms = new int[maxPoint];
        var same = new int[maxPoint];

        for (var i = 0; i < tops.Length; ++i)
        {
            ++countTops[tops[i]];
            ++countBottoms[bottoms[i]];

            if (tops[i] == bottoms[i])
            {
                ++same[tops[i]];
            }
        }

        for (var i = 1; i < maxPoint; ++i)
        {
            if (countTops[i] + countBottoms[i] - same[i] == tops.Length)
            {
                return Math.Min(countTops[i], countBottoms[i]) - same[i];
            }
        }

        return -1;
    }
}
