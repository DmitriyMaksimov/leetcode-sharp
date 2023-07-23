namespace leetcode_sharp;

public class UnionFind
{
    private readonly int[] _component;
    private int _distinctComponents;

    // Initially all nodes are in different components
    public UnionFind(int n)
    {
        _distinctComponents = n;
        _component = Enumerable.Range(0, n + 1).ToArray();
    }

    // Unite components
    // Returns true when nodes 'a' and 'b' were in different components
    public bool Unite(int a, int b)
    {
        if (FindComponent(a) == FindComponent(b))
        {
            return false;
        }

        _component[FindComponent(a)] = b;
        _distinctComponents--;

        return true;
    }

    // Returns component the node 'a' belongs to
    public int FindComponent(int a)
    {
        if (_component[a] != a)
        {
            _component[a] = FindComponent(_component[a]);
        }

        return _component[a];
    }

     // Are all nodes united into a single component?
    public bool United()
    {
        return _distinctComponents == 1;
    }
}