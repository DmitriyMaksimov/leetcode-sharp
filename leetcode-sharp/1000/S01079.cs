namespace leetcode_sharp;

// 1079. Letter Tile Possibilities
// https://leetcode.com/problems/letter-tile-possibilities
public class S01079
{
    private const int MaxChars = 26;

    public int NumTilePossibilities(string tiles)
    {
        var count = new int[MaxChars];

        foreach (var tile in tiles)
        {
            count[tile - 'A']++;
        }

        return dfs(count);
    }

    private static int dfs(int[] arr)
    {
        var sum = 0;

        for (var i = 0; i < MaxChars; i++)
        {
            if (arr[i] == 0) continue;

            arr[i]--;
            sum += dfs(arr) + 1;
            arr[i]++;
        }

        return sum;
    }
}