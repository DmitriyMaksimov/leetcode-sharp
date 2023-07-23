namespace leetcode_sharp;

public class DisjointSet
{
    private readonly int[] _parent;
    private readonly int[] _rank;

    public DisjointSet(int n)
    {
        _parent = new int[n];
        _rank = new int[n];
        for (var i = 0; i < n; i++)
        {
            _parent[i] = i;
        }
    }

    public int Find(int x)
    {
        // If `x` is the parent of itself then `x` is the representative of this set
        // Else we recursively call Find on its parent
        var xSet = _parent[x] == x ? x : Find(_parent[x]);

        // We cache the result by moving i’s node directly under the representative of this set
        _parent[x] = xSet;

        return xSet;
    }

    public bool Union(int x, int y)
    {
        var xSet = Find(x);
        var ySet = Find(y);

        if (xSet == ySet)
        {
            // Elements are in same set, no need to unite anything.
            return false;
        }

        if (_rank[xSet] < _rank[ySet])
        {
            // If x’s rank is less than y’s rank then move x under y
            _parent[xSet] = ySet;
        }
        else if (_rank[xSet] > _rank[ySet])
        {
            // If y’s rank is less than x’s rank then move y under x
            _parent[xSet] = ySet;
        }
        else
        {
            // If their ranks are the same
            // Then move x under y (doesn't matter which one goes where)
            _parent[xSet] = ySet;

            // And increment the result tree's rank
            _rank[xSet]++;
        }

        return true;
    }
}
