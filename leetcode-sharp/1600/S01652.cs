namespace leetcode_sharp;

// 1652. Defuse the Bomb
// https://leetcode.com/problems/defuse-the-bomb/
public class S01652
{
    public int[] Decrypt(int[] code, int k)
    {
        var result = new int[code.Length];

        if (k == 0)
        {
            return result;
        }

        var sum = 0;
        var start = 1;
        var end = k;

        if (k < 0)
        {
            start = code.Length + k;
            end = code.Length - 1;
        }

        for (var i = start; i <= end; i++)
        {
            sum += code[i];
        }

        for (var i = 0; i < code.Length; i++)
        {
            result[i] = sum;
            sum -= code[(start + i) % code.Length];
            sum += code[(end + 1 + i) % code.Length];
        }

        return result;
    }
}