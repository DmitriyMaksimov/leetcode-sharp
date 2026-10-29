namespace leetcode_sharp;

// 3841. Palindromic Path Queries in a Tree
// https://leetcode.com/problems/palindromic-path-queries-in-a-tree
public class S03841
{
    private int _n;
    private List<int>[] _adj;
    private int[] _parent;
    private int[] _depth;
    private int[] _heavy;
    private int[] _head;
    private int[] _pos;
    private int[] _val;
    private int _curPos;

    private class SegmentTree
    {
        private int[] _tree;

        public SegmentTree(int n)
        {
            _tree = new int[4 * n];
        }

        public void Update(int node, int start, int end, int idx, int value)
        {
            if (start == end)
            {
                _tree[node] = value;
                return;
            }

            var mid = start + (end - start) / 2;

            if (idx <= mid)
            {
                Update(2 * node, start, mid, idx, value);
            }
            else
            {
                Update(2 * node + 1, mid + 1, end, idx, value);
            }

            _tree[node] = _tree[2 * node] ^ _tree[2 * node + 1];
        }

        public int Query(int node, int start, int end, int l, int r)
        {
            if (r < start || end < l)
            {
                return 0;
            }

            if (l <= start && end <= r)
            {
                return _tree[node];
            }

            var mid = start + (end - start) / 2;

            return Query(2 * node, start, mid, l, r) ^ Query(2 * node + 1, mid + 1, end, l, r);
        }
    }

    private int Dfs(int u, int p, int d)
    {
        _depth[u] = d;
        _parent[u] = p;

        var size = 1;
        var maxChildSize = 0;

        foreach (var v in _adj[u])
        {
            if (v == p)
            {
                continue;
            }

            var childSize = Dfs(v, u, d + 1);
            size += childSize;

            if (childSize > maxChildSize)
            {
                maxChildSize = childSize;
                _heavy[u] = v;
            }
        }

        return size;
    }

    private void Decompose(int u, int h)
    {
        _head[u] = h;
        _pos[u] = _curPos++;

        if (_heavy[u] != -1)
        {
            Decompose(_heavy[u], h);
        }

        foreach (var v in _adj[u])
        {
            if (v != _parent[u] && v != _heavy[u])
            {
                Decompose(v, v);
            }
        }
    }

    private int QueryPath(int u, int v, SegmentTree segTree)
    {
        var result = 0;

        while (_head[u] != _head[v])
        {
            if (_depth[_head[u]] > _depth[_head[v]])
            {
                (u, v) = (v, u);
            }

            result ^= segTree.Query(1, 0, _n - 1, _pos[_head[v]], _pos[v]);

            v = _parent[_head[v]];
        }

        if (_depth[u] > _depth[v])
        {
            (u, v) = (v, u);
        }

        result ^= segTree.Query(1, 0, _n - 1, _pos[u], _pos[v]);

        return result;
    }

    public IList<bool> PalindromePath(int n, int[][] edges, string s, string[] queries)
    {
        _n = n;
        _adj = new List<int>[n];

        for (var i = 0; i < n; i++)
        {
            _adj[i] = [];
        }

        foreach (var e in edges)
        {
            _adj[e[0]].Add(e[1]);
            _adj[e[1]].Add(e[0]);
        }

        _parent = new int[n];
        _depth = new int[n];
        _heavy = [.. Enumerable.Repeat(-1, n)];
        _head = new int[n];
        _pos = new int[n];

        Dfs(0, -1, 0);

        _curPos = 0;
        Decompose(0, 0);

        var segTree = new SegmentTree(n);

        _val = new int[n];

        for (var i = 0; i < n; i++)
        {
            _val[i] = 1 << (s[i] - 'a');

            segTree.Update(1, 0, n - 1, _pos[i], _val[i]);
        }

        var result = new List<bool>();

        foreach (var query in queries)
        {
            var parts = query.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var type = parts[0];

            if (type == "update")
            {
                var u = int.Parse(parts[1]);
                var c = parts[2][0];

                _val[u] = 1 << (c - 'a');

                segTree.Update(1, 0, n - 1, _pos[u], _val[u]);
            }
            else
            {
                var u = int.Parse(parts[1]);
                var v = int.Parse(parts[2]);

                var mask = QueryPath(u, v, segTree);

                result.Add((mask & (mask - 1)) == 0);
            }
        }

        return result;
    }
}