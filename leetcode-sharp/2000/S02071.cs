namespace leetcode_sharp;

// 2071. Maximum Number of Tasks You Can Assign
// https://leetcode.com/problems/maximum-number-of-tasks-you-can-assign
public class S02071
{
    public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength)
    {
        Array.Sort(tasks);
        Array.Sort(workers);

        var start = 0;
        var end = Math.Min(tasks.Length, workers.Length) + 1;

        while (start + 1 < end)
        {
            var mid = start + (end - start) / 2;

            if (Check(mid, workers, pills, tasks, strength))
            {
                start = mid;
            }
            else
            {
                end = mid;
            }
        }

        return start;
    }

    private static bool Check(int k, int[] workers, int pills, int[] tasks, int strength)
    {
        var strongestWorkers = new List<int>();
        for (var i = workers.Length - k; i < workers.Length; i++)
        {
            strongestWorkers.Add(workers[i]);
        }

        strongestWorkers.Sort();
        var tries = pills;

        for (var i = k - 1; i >= 0; i--)
        {
            var task = tasks[i];

            var pos = strongestWorkers.BinarySearch(task);
            if (pos < 0)
            {
                pos = ~pos;
            }

            if (pos < strongestWorkers.Count)
            {
                strongestWorkers.RemoveAt(pos);
            }
            else if (tries > 0)
            {
                var needed = task - strength;
                var pos2 = strongestWorkers.BinarySearch(needed);
                if (pos2 < 0)
                {
                    pos2 = ~pos2;
                }

                if (pos2 < strongestWorkers.Count)
                {
                    strongestWorkers.RemoveAt(pos2);
                    tries--;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
