namespace leetcode_sharp;

// 3321. Find X-Sum of All K-Long Subarrays II
// https://leetcode.com/problems/find-x-sum-of-all-k-long-subarrays-ii
public class S03321
{
    private static readonly IComparer<(int Val, int Freq)> PairComparer =
        Comparer<(int Val, int Freq)>.Create((a, b) =>
        {
            var freqCmp = a.Freq.CompareTo(b.Freq);
            return freqCmp != 0 ? freqCmp : a.Val.CompareTo(b.Val);
        });

    private long _sum;
    private readonly Dictionary<int, int> _map = new();
    private readonly SortedSet<(int Val, int Freq)> _large = new(PairComparer);
    private readonly SortedSet<(int Val, int Freq)> _small = new(PairComparer);

    public long[] FindXSum(int[] nums, int k, int x)
    {
        var n = nums.Length;
        var ans = new long[n - k + 1];

        foreach (var num in nums)
        {
            _small.Add((num, 0));
        }

        for (var i = 0; i < n; i++)
        {
            Update(nums[i], 1);
        
            if (i >= k)
            {
                Update(nums[i - k], -1);
            }

            if (i >= k - 1)
            {
                Equilibrium(x);
                ans[i - k + 1] = _sum;
            }
        }

        return ans;
    }


    private void Update(int x, int v)
    {
        _map.TryGetValue(x, out var freq);

        var current = (x, freq);
        if (_large.Contains(current))
        {
            _large.Remove(current);
            _sum -= (long)freq * x;
            _map[x] = freq + v;
            _sum += (long)_map[x] * x;
            _large.Add((x, _map[x]));
        }
        else if (_small.Contains(current))
        {
            _small.Remove(current);
            _map[x] = freq + v;
            _small.Add((x, _map[x]));
        }
    }

    private void Equilibrium(int x)
    {
        while (_large.Count < x && _small.Count > 0)
        {
            var second = _small.Max;
            _small.Remove(second);
            _large.Add(second);
            _sum += (long)second.Val * second.Freq;
        }

        if (_small.Count == 0)
        {
            return;
        }

        while (true)
        {
            var first = _large.Min;
            var second = _small.Max;

            if (first.Freq < second.Freq || (first.Freq == second.Freq && first.Val < second.Val))
            {
                _large.Remove(first);
                _small.Remove(second);
                _large.Add(second);
                _small.Add(first);
                _sum -= (long)first.Val * first.Freq;
                _sum += (long)second.Val * second.Freq;
            }
            else
            {
                break;
            }
        }
    }
}