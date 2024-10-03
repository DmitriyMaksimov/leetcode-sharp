namespace leetcode_sharp;

// 1590. Make Sum Divisible by P
// https://leetcode.com/problems/make-sum-divisible-by-p
public class S01590
{
    public int MinSubarray(int[] nums, int p)
    {
        var need = nums.Aggregate(0, (current, num) => (current + num) % p);
        var n = nums.Length;
        var res = n;
        var cur = 0;

        var last = new Dictionary<int, int> { [0] = -1 };

        for (var i = 0; i < n; ++i)
        {
            cur = (cur + nums[i]) % p;
            last[cur] = i;
            var want = (cur - need + p) % p;
            res = Math.Min(res, i - last.GetValueOrDefault(want, -n));
        }

        return res < n ? res : -1;
    }
}
