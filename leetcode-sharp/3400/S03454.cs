namespace leetcode_sharp;

// 3454. Separate Squares II
// https://leetcode.com/problems/separate-squares-ii
public class S03454
{
    public double SeparateSquares(int[][] squares)
    {
        var events = new List<(int y, int type, int x1, int x2)>();
        var xs = new HashSet<int>();

        foreach (var square in squares)
        {
            var x = square[0];
            var y = square[1];
            var l = square[2];
            events.Add((y, 1, x, x + l));
            events.Add((y + l, -1, x, x + l));
            xs.Add(x);
            xs.Add(x + l);
        }

        events.Sort((a, b) => a.y.CompareTo(b.y));

        var xCoords = xs.OrderBy(x => x).ToArray();
        var index = new Dictionary<int, int>();
        for (var i = 0; i < xCoords.Length; i++)
        {
            index[xCoords[i]] = i;
        }

        var seg = new SegmentTree(xCoords);

        double total = 0;
        var slabs = new List<(int y, int h, double w)>();

        var prevY = events[0].y;
        var iEvent = 0;

        while (iEvent < events.Count)
        {
            var y = events[iEvent].y;
            var dy = y - prevY;

            if (dy > 0)
            {
                var w = seg.TotalCoveredLength;
                if (w > 0)
                {
                    slabs.Add((prevY, dy, w));
                    total += dy * w;
                }
            }

            while (iEvent < events.Count && events[iEvent].y == y)
            {
                var e = events[iEvent];
                seg.Update(index[e.x1], index[e.x2] - 1, e.type);
                iEvent++;
            }

            prevY = y;
        }

        var half = total / 2;
        double acc = 0;

        foreach (var (y, h, w) in slabs)
        {
            var area = h * w;
            if (acc + area >= half)
            {
                return y + (half - acc) / w;
            }

            acc += area;
        }

        return 0.0;
    }

    private sealed class SegmentTree
    {
        private readonly int _n;
        private readonly int[] _count;
        private readonly double[] _length;
        private readonly int[] _xs;

        public double TotalCoveredLength => _length[1];

        public SegmentTree(int[] xs)
        {
            _xs = xs;
            _n = xs.Length - 1;
            _count = new int[_n * 4];
            _length = new double[_n * 4];
        }

        public void Update(int l, int r, int val)
        {
            Update(1, 0, _n - 1, l, r, val);
        }

        private void Update(int node, int start, int end, int l, int r, int val)
        {
            if (r < start || end < l)
            {
                return;
            }

            if (l <= start && end <= r)
            {
                _count[node] += val;
            }
            else
            {
                var mid = (start + end) >> 1;
                Update(node << 1, start, mid, l, r, val);
                Update(node << 1 | 1, mid + 1, end, l, r, val);
            }

            if (_count[node] > 0)
            {
                _length[node] = _xs[end + 1] - _xs[start];
            }
            else if (start == end)
            {
                _length[node] = 0;
            }
            else
            {
                _length[node] = _length[node << 1] + _length[node << 1 | 1];
            }
        }
    }
}