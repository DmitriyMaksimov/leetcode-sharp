using System.Text;

namespace leetcode_sharp;

// 752. Open the Lock
// https://leetcode.com/problems/open-the-lock
public class S00752
{
    public int OpenLock(string[] deadends, string target)
    {
        Queue<string> q = [];
        q.Enqueue("0000");
        var deads = deadends.ToHashSet();
        HashSet<string> visited = ["0000"];
        var level = 0;

        while (q.Count != 0)
        {
            var size = q.Count;
            while (size > 0)
            {
                var s = q.Dequeue();
                if (deads.Contains(s))
                {
                    size--;
                    continue;
                }

                if (s == target)
                {
                    return level;
                }

                for (var i = 0; i < 4; i++)
                {
                    var c = s[i];
                    var s1 = s[..i] + (c == '9' ? 0 : c - '0' + 1) + s[(i + 1)..];
                    var s2 = s[..i] + (c == '0' ? 9 : c - '0' - 1) + s[(i + 1)..];

                    if (!visited.Contains(s1) && !deads.Contains(s1))
                    {
                        q.Enqueue(s1);
                        visited.Add(s1);
                    }

                    if (!visited.Contains(s2) && !deads.Contains(s2))
                    {
                        q.Enqueue(s2);
                        visited.Add(s2);
                    }
                }

                size--;
            }

            level++;
        }

        return -1;
    }
}