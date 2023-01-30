namespace leetcode_sharp;

// 1137. N-th Tribonacci Number
// https://leetcode.com/problems/n-th-tribonacci-number/
public class S01137
{
    private readonly Dictionary<int, int> _cache = new() {{0, 0}, {1, 1}, {2, 1}};

    public int Tribonacci(int n)
    {
        if (_cache.TryGetValue(n, out var val))
        {
            return val;
        }

        return _cache[n] = Tribonacci(n - 3) + Tribonacci(n - 2) + Tribonacci(n - 1);
    }
}