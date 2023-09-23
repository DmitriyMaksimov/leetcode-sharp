namespace leetcode_sharp;

// 2432. The Employee That Worked on the Longest Task
// https://leetcode.com/problems/the-employee-that-worked-on-the-longest-task/
public class S02432
{
    public int HardestWorker(int n, int[][] logs)
    {
        var prev = 0;
        var max = 0;
        var result = 0;

        foreach (var item in logs)
        {
            var len = item[1] - prev;

            if (len > max || len == max && result > item[0])
            {
                max = len;
                result = item[0];
            }

            prev = item[1];
        }

        return result;
    }
}