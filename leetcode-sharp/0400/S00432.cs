namespace leetcode_sharp;

// 432. All O`one Data Structure
// https://leetcode.com/problems/all-oone-data-structure
public static class S00432
{
public class AllOne
{
    private record FrequencyStrings(int Frequency, HashSet<string> Strings);

    private readonly Dictionary<string, LinkedListNode<FrequencyStrings>> _stringsDictionary = [];
    private readonly LinkedList<FrequencyStrings> _linkedList = [];

    public void Inc(string key)
    {
        if (_stringsDictionary.TryGetValue(key, out var node))
        {
            node.Value.Strings.Remove(key);
            var nextFreq = node.Value.Frequency + 1;
            if (node.Next == null || node.Next.Value.Frequency != nextFreq)
            {
                _linkedList.AddAfter(node, new FrequencyStrings(nextFreq, []));
            }

            node.Next!.Value.Strings.Add(key);
            _stringsDictionary[key] = node.Next;

            if (node.Value.Strings.Count == 0)
            {
                _linkedList.Remove(node);
            }
        }
        else
        {
            if (_linkedList.Count == 0 || _linkedList.First!.Value.Frequency != 1)
            {
                _linkedList.AddFirst(new FrequencyStrings(1, []));
            }

            _linkedList.First!.Value.Strings.Add(key);
            _stringsDictionary.Add(key, _linkedList.First);
        }
    }

    public void Dec(string key)
    {
        var node = _stringsDictionary[key];
        node.Value.Strings.Remove(key);

        var prevFreq = node.Value.Frequency - 1;

        if (prevFreq > 0)
        {
            if (node.Previous == null || node.Previous.Value.Frequency != prevFreq)
            {
                var newNode = new FrequencyStrings(prevFreq, []);
                _linkedList.AddBefore(node, newNode);
            }

            node.Previous!.Value.Strings.Add(key);
            _stringsDictionary[key] = node.Previous;
        }

        if (node.Value.Strings.Count == 0)
        {
            _linkedList.Remove(node);
        }

        if (prevFreq == 0)
        {
            _stringsDictionary.Remove(key);
        }
    }

    public string GetMaxKey()
    {
        return _linkedList.Count == 0 ? "" : _linkedList.Last!.Value.Strings.First();
    }

    public string GetMinKey()
    {
        return _linkedList.Count == 0 ? "" : _linkedList.First!.Value.Strings.First();
    }
}
}
