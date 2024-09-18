namespace leetcode_sharp;

// 1029. Two City Scheduling
// https://leetcode.com/problems/two-city-scheduling
public class S01029
{
    public int TwoCitySchedCost(int[][] costs)
    {
        var firstCity = costs.Select(x => x[0]).Sum();
        var diff = costs.Select(x => x[1] - x[0]).Order();

        return firstCity + diff.Take(costs.Length / 2).Sum();
    }
}
