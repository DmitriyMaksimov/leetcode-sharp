namespace leetcode_sharp;

// 210. Course Schedule II
// https://leetcode.com/problems/course-schedule-ii/
public class S00210
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        var n = prerequisites.Length;

        var arr = new List<List<int>>();
        for (var i = 0; i < numCourses; i++)
        {
            arr.Add([]);
        }

        for (var i = 0; i < n; i++)
        {
            arr[prerequisites[i][0]].Add(prerequisites[i][1]);
        }

        var inp = new int[numCourses];

        for (var i = 0; i < numCourses; i++)
        {
            foreach (var it in arr[i])
            {
                inp[it]++;
            }
        }

        var q = new Queue<int>();
        for (var i = 0; i < numCourses; i++)
        {
            if (inp[i] == 0)
            {
                q.Enqueue(i);
            }
        }

        var res = new List<int>();
        while (q.Count != 0)
        {
            var node = q.Dequeue();

            res.Add(node);
            foreach (var i in arr[node])
            {
                if (--inp[i] == 0)
                {
                    q.Enqueue(i);
                }
            }
        }

        var ans = new int[res.Count];
        for (var i = res.Count - 1; i >= 0; i--)
        {
            ans[ans.Length - i - 1] = res[i];
        }

        return res.Count != numCourses ? [] : ans;
    }
}