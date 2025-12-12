namespace leetcode_sharp;

// 3433. Count Mentions Per User
// https://leetcode.com/problems/count-mentions-per-user
public class S03433
{
    public int[] CountMentions(int numberOfUsers, IList<IList<string>> events)
    {
        var sorted = events
            .OrderBy(e => int.Parse(e[1]))
            .ThenBy(e => e[0][2])
            .ToList();

        var result = new int[numberOfUsers];
        var onlineT = new int[numberOfUsers];

        foreach (var e in sorted)
        {
            var curT = int.Parse(e[1]);
            var mention = e[2];

            if (e[0][0] == 'O')
            {
                var user = int.Parse(mention);
                onlineT[user] = curT + 60;
            }
            else if (mention[0] == 'A')
            {
                for (var i = 0; i < numberOfUsers; i++)
                {
                    result[i]++;
                }
            }
            else if (mention[0] == 'H')
            {
                for (var i = 0; i < numberOfUsers; i++)
                {
                    if (onlineT[i] <= curT)
                    {
                        result[i]++;
                    }
                }
            }
            else
            {
                var parts = mention.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var p in parts)
                {
                    if (p.Length >= 3)
                    {
                        var userId = int.Parse(p[2..]);
                        result[userId]++;
                    }
                }
            }
        }

        return result;
    }
}