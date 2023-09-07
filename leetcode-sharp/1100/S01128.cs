namespace leetcode_sharp;

// 1128. Number of Equivalent Domino Pairs
// https://leetcode.com/problems/number-of-equivalent-domino-pairs/
public class S01128
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        var dict = new Dictionary<int, int>();
        var result = 0;
        foreach (var domino in dominoes)
        {
            var key = Math.Min(domino[0], domino[1]) * 10 + Math.Max(domino[0], domino[1]);

            if (dict.ContainsKey(key))
            {
                result += dict[key];
                dict[key]++;
            }
            else
            {
                dict.Add(key, 1);
            }
        }

        return result;
    }
}