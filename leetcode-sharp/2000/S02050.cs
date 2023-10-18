namespace leetcode_sharp;

// 2050. Parallel Courses III
// https://leetcode.com/problems/parallel-courses-iii
public class S02050
{
    public int MinimumTime(int n, int[][] relations, int[] time)
    {
        var graph = new List<List<int>>();
        for (var i = 0; i < n; i++)
        {
            graph.Add(new List<int>());
        }

        foreach (var relation in relations)
        {
            var prev = relation[0] - 1;
            var next = relation[1] - 1;
            graph[next].Add(prev);
        }

        var memo = new int[n];
        var overallMinTime = 0;

        for (var course = 0; course < n; course++)
        {
            overallMinTime = Math.Max(overallMinTime, calculateTime(course, graph, time, memo));
        }

        return overallMinTime;
    }

    private static int calculateTime(int course, List<List<int>> graph, IReadOnlyList<int> time, IList<int> memo)
    {
        if (memo[course] != 0)
        {
            return memo[course];
        }

        var maxPrerequisiteTime = 0;
        foreach (var prerequisite in graph[course])
        {
            maxPrerequisiteTime = Math.Max(maxPrerequisiteTime, calculateTime(prerequisite, graph, time, memo));
        }

        memo[course] = maxPrerequisiteTime + time[course];
        return memo[course];
    }
}
