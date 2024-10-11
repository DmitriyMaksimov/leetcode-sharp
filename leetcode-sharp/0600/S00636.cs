namespace leetcode_sharp;

// 636. Exclusive Time of Functions
// https://leetcode.com/problems/exclusive-time-of-functions
public class S00636
{
    public int[] ExclusiveTime(int n, IList<string> logs)
    {
        var res = new int[n];
        Stack<int> stack = [];
        var prevTime = 0;

        foreach (var log in logs)
        {
            var parts = log.Split(":");

            if (stack.Count != 0)
            {
                res[stack.Peek()] += int.Parse(parts[2]) - prevTime;
            }

            prevTime = int.Parse(parts[2]);

            if (parts[1].Equals("start"))
            {
                stack.Push(int.Parse(parts[0]));
            }
            else
            {
                res[stack.Pop()]++;
                prevTime++;
            }
        }

        return res;
    }
}
