namespace leetcode_sharp;

// 554. Brick Wall
// https://leetcode.com/problems/brick-wall
public class S00554
{
    public int LeastBricks(IList<IList<int>> wall)
    {
        var map = new Dictionary<int, int>();
        var count = 0;

        foreach (var row in wall)
        {
            var sum = 0;

            for (var i = 0; i < row.Count - 1; i++)
            {
                sum += row[i];
                map[sum] = map.GetValueOrDefault(sum) + 1;
                count = Math.Max(count, map[sum]);
            }
        }

        return wall.Count - count;
    }
}
