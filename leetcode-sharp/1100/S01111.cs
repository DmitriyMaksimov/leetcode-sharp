namespace leetcode_sharp;

// 1111. Maximum Nesting Depth of Two Valid Parentheses Strings
// https://leetcode.com/problems/maximum-nesting-depth-of-two-valid-parentheses-strings
public class S01111
{
    public int[] MaxDepthAfterSplit(string seq)
    {
        var n = seq.Length;
        var result = new int[n];

        for (var i = 0; i < n; ++i)
        {
            result[i] = seq[i] == '(' ? i % 2 : 1 - i % 2;
        }

        return result;
    }
}