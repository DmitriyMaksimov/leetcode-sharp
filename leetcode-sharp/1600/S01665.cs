namespace leetcode_sharp;

// 1665. Minimum Initial Energy to Finish Tasks
// https://leetcode.com/problems/minimum-initial-energy-to-finish-tasks
public class S01665
{
    public int MinimumEffort(int[][] tasks)
    {
        Array.Sort(tasks, (t1, t2) => (t1[1] - t1[0]).CompareTo(t2[1] - t2[0]));

        return tasks.Aggregate(0, (current, a) => Math.Max(current + a[0], a[1]));
    }
}