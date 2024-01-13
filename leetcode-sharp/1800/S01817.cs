namespace leetcode_sharp;

// 1817. Finding the Users Active Minutes
// https://leetcode.com/problems/finding-the-users-active-minutes
public class S01817
{
    public int[] FindingUsersActiveMinutes(int[][] logs, int k)
    {
        var userActiveMinutes = new Dictionary<int, HashSet<int>>();

        foreach (var log in logs)
        {
            var userId = log[0];
            var taskPerformedAtTime = log[1];

            userActiveMinutes.TryAdd(userId, new HashSet<int>());
            userActiveMinutes[userId].Add(taskPerformedAtTime);
        }

        var result = new int[k];
        
        foreach (var (_, totalTimeTaken) in userActiveMinutes)
        {
            result[totalTimeTaken.Count - 1]++;
        }

        return result;
    }
}