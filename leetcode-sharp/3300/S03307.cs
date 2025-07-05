namespace leetcode_sharp;

// 3307. Find the K-th Character in String Game II
// https://leetcode.com/problems/find-the-k-th-character-in-string-game-ii
public class S03307
{
    public char KthCharacter(long k, int[] operations)
    {
        var shift = 0;
        var lengths = new List<long>();
        var len = 1L;

        foreach (var _ in operations)
        {
            len *= 2;
            lengths.Add(len);
            if (len >= k)
            {
                break;
            }
        }

        for (var i = lengths.Count - 1; i >= 0; i--)
        {
            var half = lengths[i] / 2;
            var op = operations[i];

            if (k > half)
            {
                k -= half;
                if (op == 1)
                {
                    shift++;
                }
            }
        }

        return (char)(shift % 26 + 'a');
    }
}