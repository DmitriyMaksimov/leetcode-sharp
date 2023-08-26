namespace leetcode_sharp;

// 646. Maximum Length of Pair Chain
// https://leetcode.com/problems/maximum-length-of-pair-chain/
public class S00646
{
    public int FindLongestChain(int[][] pairs)
    {
        Array.Sort(pairs, (a, b) => a[1] - b[1]);

        var cur = int.MinValue;
        var ans = 0;

        foreach (var pair in pairs)
        {
            if (cur < pair[0])
            {
                cur = pair[1];
                ans++;
            }
        }

        return ans;
    }
}