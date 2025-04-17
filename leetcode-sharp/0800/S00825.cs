namespace leetcode_sharp;

// 825. Friends Of Appropriate Ages
// https://leetcode.com/problems/friends-of-appropriate-ages
public class S00825
{
    public int NumFriendRequests(int[] ages)
    {
        const int maxAge = 120;
        const int minAge = 15;

        var ageCounts = new int[maxAge + 1];

        foreach (var age in ages)
        {
            ageCounts[age]++;
        }

        var result = 0;

        for (var i = minAge; i <= maxAge; i++)
        {
            if (ageCounts[i] == 0)
            {
                continue;
            }

            for (var j = (int)(0.5 * i + 8); j <= i; j++)
            {
                if (ageCounts[j] == 0)
                {
                    continue;
                }

                result += ageCounts[i] * (ageCounts[j] - (i == j ? 1 : 0));
            }
        }

        return result;
    }
}
