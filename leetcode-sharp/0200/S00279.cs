namespace leetcode_sharp;

// 279. Perfect Squares
// https://leetcode.com/problems/perfect-squares/
public class S00279
{
    private Dictionary<int, int> cache = new();
    
    public int NumSquares(int n)
    {
        if (n == 0) return 0;
        if (cache.ContainsKey(n))
        {
            return cache[n];
        }
        
        var mnCount = int.MaxValue;
        for (var num = 1; num <= Math.Sqrt(n); num++)
        {
            var sqNum = num * num;
            var currCount = 1 + NumSquares(n - sqNum);
            mnCount = Math.Min(mnCount, currCount);
        }

        cache[n] = mnCount;
        
        return mnCount;
    }
}