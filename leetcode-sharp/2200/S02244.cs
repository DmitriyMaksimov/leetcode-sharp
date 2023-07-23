namespace leetcode_sharp;

// 2244. Minimum Rounds to Complete All Tasks
// https://leetcode.com/problems/minimum-rounds-to-complete-all-tasks/
public class S02244
{
    public int MinimumRounds(int[] tasks)
    {
        if (tasks.Length == 1)
        {
            return -1;
        }

        var result = 0;
        Array.Sort(tasks);

        var count = 1;
        
        for (var i = 1; i < tasks.Length; i++)
        {
            if (tasks[i] == tasks[i - 1])
            {
                ++count;
                continue;
            }

            if (count == 1)
            {
                return -1;
            }
            
            result += (count + 2) / 3;
            count = 1;
        }

        if (count == 1)
        {
            return -1;
        }

        result += (count + 2) / 3;

        return result;
    }
}