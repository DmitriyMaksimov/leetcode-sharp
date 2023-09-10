namespace leetcode_sharp;

// 1598. Crawler Log Folder
// https://leetcode.com/problems/crawler-log-folder/
public class S01598
{
    public int MinOperations(string[] logs)
    {
        var depth = 0;
        foreach (var log in logs)
        {
            if (log == "../")
            {
                if (depth > 0)
                {
                    depth--;
                }
            }
            else if (log != "./")
            {
                depth++;
            }
        }

        return depth;
    }
}