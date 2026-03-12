namespace leetcode_sharp;

// 3600. Maximize Spanning Tree Stability with Upgrades
// https://leetcode.com/problems/maximize-spanning-tree-stability-with-upgrades
public class S03600
{
    private sealed class Dsu
    {
        private readonly int[] _parent;
        private readonly byte[] _rank;

        public int Components;

        public Dsu(int n)
        {
            _parent = new int[n];
            _rank = new byte[n];
            Components = n;

            for (var i = 0; i < n; i++)
            {
                _parent[i] = i;
            }
        }

        private int Find(int x)
        {
            while (_parent[x] != x)
            {
                _parent[x] = _parent[_parent[x]];
                x = _parent[x];
            }

            return x;
        }

        public bool Unite(int a, int b)
        {
            var pa = Find(a);
            var pb = Find(b);

            if (pa == pb)
            {
                return false;
            }

            if (_rank[pa] < _rank[pb])
            {
                (pa, pb) = (pb, pa);
            }

            _parent[pb] = pa;

            if (_rank[pa] == _rank[pb])
            {
                _rank[pa]++;
            }

            Components--;
            return true;
        }
    }

    private bool CanAchieve(int n, int[][] edges, int k, int x)
    {
        var dsu = new Dsu(n);

        var m = edges.Length;

        for (var i = 0; i < m; i++)
        {
            var e = edges[i];
            var u = e[0];
            var v = e[1];
            var s = e[2];
            var must = e[3];

            if (must != 1)
            {
                continue;
            }

            if (s < x)
            {
                return false;
            }

            if (!dsu.Unite(u, v))
            {
                return false;
            }
        }

        for (var i = 0; i < m; i++)
        {
            var e = edges[i];

            if (e[3] == 0 && e[2] >= x)
            {
                dsu.Unite(e[0], e[1]);
            }
        }

        var usedUpgrades = 0;

        for (var i = 0; i < m; i++)
        {
            var e = edges[i];

            if (e[3] == 0 && e[2] < x && 2 * e[2] >= x && dsu.Unite(e[0], e[1]))
            {
                usedUpgrades++;
                
                if (usedUpgrades > k)
                {
                    return false;
                }
            }
        }

        return dsu.Components == 1;
    }

    public int MaxStability(int n, int[][] edges, int k)
    {
        var dsu = new Dsu(n);
        var m = edges.Length;

        for (var i = 0; i < m; i++)
        {
            var e = edges[i];

            if (e[3] == 1 && !dsu.Unite(e[0], e[1]))
            {
                return -1;
            }
        }

        var low = 1;
        var high = 200000;
        var result = -1;

        while (low <= high)
        {
            var mid = (low + high) >> 1;

            if (CanAchieve(n, edges, k, mid))
            {
                result = mid;
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return result;
    }
}