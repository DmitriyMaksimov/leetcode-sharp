namespace leetcode_sharp;

// 2682. Find the Losers of the Circular Game
// https://leetcode.com/problems/find-the-losers-of-the-circular-game
public class S02682
{
    public int[] CircularGameLosers(int n, int k)
    {
        var visited = new bool[n];
        var current = 0;
        var step = 1;

        do
        {
            visited[current] = true;
            current = (current + step * k) % n;
            step++;
        } while (!visited[current]);

        var result = new List<int>(n);

        for (var i = 0; i < n; i++)
        {
            if (!visited[i]) result.Add(i + 1);
        }

        return result.ToArray();
    }
}