namespace leetcode_sharp;

// 948. Bag of Tokens
// https://leetcode.com/problems/bag-of-tokens
public class S00948
{
    public int BagOfTokensScore(int[] tokens, int power)
    {
        Array.Sort(tokens);

        var res = 0;

        for (int i = 0, j = tokens.Length - 1, points = 0; i <= j;)
        {
            if (power >= tokens[i])
            {
                power -= tokens[i++];
                res = Math.Max(res, ++points);
            }
            else if (points > 0)
            {
                points--;
                power += tokens[j--];
            }
            else
            {
                break;
            }
        }

        return res;
    }
}