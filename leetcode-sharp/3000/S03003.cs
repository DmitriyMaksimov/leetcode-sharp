using System.Numerics;

namespace leetcode_sharp;

// 3003. Maximize the Number of Partitions After Operations
// https://leetcode.com/problems/maximize-the-number-of-partitions-after-operations
public class S03003
{
    private const int MaxCharacters = 26;
    private int _k;
    private readonly Dictionary<long, int> _cache = new(capacity: 10_000);

    public int MaxPartitionsAfterOperations(string s, int k)
    {
        _k = k;
        _cache.Clear();
        var span = s.AsSpan();

        return Dp(span, 0, 0, true) + 1;
    }

    private int Dp(ReadOnlySpan<char> span, int index, int currentSet, bool canChange)
    {
        var key = ((long)index << 27) | ((long)currentSet << 1) | (canChange ? 1L : 0L);

        if (_cache.TryGetValue(key, out var cached))
        {
            return cached;
        }

        if (index == span.Length)
        {
            return 0;
        }

        var charIndex = span[index] - 'a';
        var updatedSet = currentSet | (1 << charIndex);
        var distinctCount = BitOperations.PopCount((uint)updatedSet);

        int result;
        if (distinctCount > _k)
        {
            result = 1 + Dp(span, index + 1, 1 << charIndex, canChange);
        }
        else
        {
            result = Dp(span, index + 1, updatedSet, canChange);
        }

        if (!canChange)
        {
            return _cache[key] = result;
        }

        for (var newChar = 0; newChar < MaxCharacters; newChar++)
        {
            var newSet = currentSet | (1 << newChar);
            var newDistinct = BitOperations.PopCount((uint)newSet);

            var candidate = newDistinct > _k
                ? 1 + Dp(span, index + 1, 1 << newChar, false)
                : Dp(span, index + 1, newSet, false);

            if (candidate > result)
            {
                result = candidate;
            }
        }

        return _cache[key] = result;
    }
}