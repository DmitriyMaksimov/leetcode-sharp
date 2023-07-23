namespace leetcode_sharp;

// 705. Design HashSet
// https://leetcode.com/problems/design-hashset/
public static class S00705
{
public class MyHashSet
{
    private const int NumberOfBuckets = 101;
    private readonly List<int>[] _buckets = new List<int>[NumberOfBuckets];
    
    public MyHashSet()
    {
        for (var i = 0; i < NumberOfBuckets; i++)
        {
            _buckets[i] = new List<int>();
        }
    }

    public void Add(int key)
    {
        var bucket = getBucket(key);
        if (!bucket.Contains(key))
        {
            bucket.Add(key);
        }
    }

    public void Remove(int key)
    {
        var bucket = getBucket(key);
        if (bucket.Contains(key))
        {
            bucket.Remove(key);
        }
    }

    public bool Contains(int key)
    {
        return getBucket(key).Contains(key);
    }

    private List<int> getBucket(int key)
    {
        var hashCode = key.GetHashCode() % NumberOfBuckets;
        return _buckets[hashCode];
    }
}
}