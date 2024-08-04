namespace leetcode_sharp;

// 3238. Find the Number of Winning Players
// https://leetcode.com/problems/find-the-number-of-winning-players
public class S03238
{
    public int WinningPlayerCount(int n, int[][] pick)
    {
        var dictionary = new Dictionary<int, Dictionary<int, int>>();

        for (var i = 0; i < n; i++)
        {
            dictionary[i] = [];
        }

        foreach (var p in pick)
        {
            var x = p[0];
            var y = p[1];
            dictionary[x][y] = dictionary[x].GetValueOrDefault(y) + 1;
        }

        var result = 0;

        foreach (var (key, value) in dictionary)
        {
            foreach (var k in value.Keys)
            {
                if (key < value[k])
                {
                    result++;
                    break;
                }
            }
        }

        return result;
    }
}
