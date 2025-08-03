namespace leetcode_sharp;

// 986. Interval List Intersections
// https://leetcode.com/problems/interval-list-intersections
public class S00986
{
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
    {
        if (firstList.Length == 0 || secondList.Length == 0)
        {
            return [];
        }

        List<int[]> result = [];

        var i = 0;
        var j = 0;

        while (i < firstList.Length && j < secondList.Length)
        {
            var startMax = Math.Max(firstList[i][0], secondList[j][0]);
            var endMin = Math.Min(firstList[i][1], secondList[j][1]);

            if (endMin >= startMax)
            {
                result.Add([startMax, endMin]);
            }

            if (firstList[i][1] == endMin)
            {
                i++;
            }

            if (secondList[j][1] == endMin)
            {
                j++;
            }
        }

        return result.ToArray();
    }
}