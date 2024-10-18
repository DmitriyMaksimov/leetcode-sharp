namespace leetcode_sharp;

// 1583. Count Unhappy Friends
// https://leetcode.com/problems/count-unhappy-friends
public class S01583
{
    public int UnhappyFriends(int n, int[][] preferences, int[][] pairs)
    {
        var map = new int[n];
        foreach (var pair in pairs)
        {
            map[pair[0]] = pair[1];
            map[pair[1]] = pair[0];
        }


        var prefer = new Dictionary<int, int>[n];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n - 1; j++)
            {
                prefer[i] ??= [];

                prefer[i][preferences[i][j]] = j;
            }
        }

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            if (preferences[i].Any(j => prefer[j][i] < prefer[j][map[j]] && prefer[i][map[i]] > prefer[i][j]))
            {
                result++;
            }
        }

        return result;
    }
}
