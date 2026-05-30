namespace leetcode_sharp;

// 3161. Block Placement Queries
// https://leetcode.com/problems/block-placement-queries
public class S03161
{
    private int[] _seg;

    private void Update(int idx, int val, int p, int l, int r)
    {
        if (l == r)
        {
            _seg[p] = val;
            return;
        }

        var mid = (l + r) >> 1;
        if (idx <= mid)
        {
            Update(idx, val, p << 1, l, mid);
        }
        else
        {
            Update(idx, val, p << 1 | 1, mid + 1, r);
        }

        _seg[p] = Math.Max(_seg[p << 1], _seg[p << 1 | 1]);
    }

    private int Query(int L, int R, int p, int l, int r)
    {
        if (L <= l && r <= R)
        {
            return _seg[p];
        }

        var mid = (l + r) >> 1;
        var res = 0;
        if (L <= mid)
        {
            res = Math.Max(res, Query(L, R, p << 1, l, mid));
        }

        if (R > mid)
        {
            res = Math.Max(res, Query(L, R, p << 1 | 1, mid + 1, r));
        }

        return res;
    }

    public IList<bool> GetResults(int[][] queries)
    {
        const int max = 50000;
        _seg = new int[max << 2];
        var st = new SortedSet<int> { 0, max };
        Update(max, max, 1, 0, max);
        var result = new List<bool>();

        foreach (var q in queries)
        {
            if (q[0] == 1)
            {
                var x = q[1];
                var r = st.GetViewBetween(x + 1, int.MaxValue).Min;
                var l = st.GetViewBetween(int.MinValue, x - 1).Max;
                Update(x, x - l, 1, 0, max);
                Update(r, r - x, 1, 0, max);
                st.Add(x);
            }
            else
            {
                var x = q[1];
                var sz = q[2];
                var pre = st.GetViewBetween(int.MinValue, x).Max;
                var maxSpace = Query(0, pre, 1, 0, max);
                maxSpace = Math.Max(maxSpace, x - pre);
                result.Add(maxSpace >= sz);
            }
        }

        return result;
    }
}