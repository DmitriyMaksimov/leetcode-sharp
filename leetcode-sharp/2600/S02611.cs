namespace leetcode_sharp;

// 2611. Mice and Cheese
// https://leetcode.com/problems/mice-and-cheese
public class S02611
{
    public int MiceAndCheese(int[] reward1, int[] reward2, int k)
    {
        var n = reward1.Length;
        var totalPoints = 0;

        for (var i = 0; i < n; i++)
        {
            reward1[i] -= reward2[i];
            totalPoints += reward2[i];
        }

        Array.Sort(reward1);

        for (var i = 0; i < k; i++)
        {
            totalPoints += reward1[n - 1 - i];
        }

        return totalPoints;
    }
}