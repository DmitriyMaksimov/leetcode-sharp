namespace leetcode_sharp;

// 318. Maximum Product of Word Lengths
// https://leetcode.com/problems/maximum-product-of-word-lengths
public class S00318
{
    public int MaxProduct(string[] words)
    {
        if (words.Length == 0)
        {
            return 0;
        }

        var len = words.Length;
        var bitMasks = new int[len];

        for (var i = 0; i < len; i++)
        {
            bitMasks[i] = words[i].Select(ch => 1 << (ch - 'a')).Aggregate(0, (acc, cur) => acc | cur);
        }

        var maxProduct = 0;

        for (var i = 0; i < len; i++)
        {
            for (var j = i + 1; j < len; j++)
            {
                if ((bitMasks[i] & bitMasks[j]) == 0)
                {
                    maxProduct = Math.Max(maxProduct, words[i].Length * words[j].Length);
                }
            }
        }

        return maxProduct;
    }
}
