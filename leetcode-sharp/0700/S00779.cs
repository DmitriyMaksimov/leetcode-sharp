namespace leetcode_sharp;

// 779. K-th Symbol in Grammar
// https://leetcode.com/problems/k-th-symbol-in-grammar
public class S00779
{
    public int KthGrammar(int n, int k)
    {
        if (n == 1) return 0;
        
        var length = 1 << (n - 2);

        return k <= length ? KthGrammar(n - 1, k) : 1 - KthGrammar(n - 1, k - length);
    }
}