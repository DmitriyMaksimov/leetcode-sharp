namespace leetcode_sharp;

// 2147. Number of Ways to Divide a Long Corridor
// https://leetcode.com/problems/number-of-ways-to-divide-a-long-corridor
public class S02147
{
    private const int Mod = 1_000_000_007;

    public int NumberOfWays(string corridor)
    {
        var n1 = 1;
        var n2 = 0;
        var n3 = 0;

        foreach (var ch in corridor)
        {
            n1 = (n1 + n3) % Mod;

            if (ch != 'S') continue;
            
            n3 = n2;
            n2 = n1;
            n1 = 0;
        }

        return n3;
    }
}