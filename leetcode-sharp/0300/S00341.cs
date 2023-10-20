namespace leetcode_sharp;

// 341. Flatten Nested List Iterator
// https://leetcode.com/problems/flatten-nested-list-iterator
public class S00341
{
    public interface NestedInteger
    {
        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }

    public class NestedIterator
    {
        private readonly List<int> _flattened;
        private int _index;

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            _flattened = Flatten(nestedList);
        }

        private List<int> Flatten(IList<NestedInteger> nested)
        {
            List<int> result = new List<int>();
            foreach (var ni in nested)
            {
                if (ni.IsInteger())
                {
                    result.Add(ni.GetInteger());
                }
                else
                {
                    result.AddRange(Flatten(ni.GetList()));
                }
            }

            return result;
        }

        public int Next()
        {
            return _flattened[_index++];
        }

        public bool HasNext()
        {
            return _index < _flattened.Count;
        }
    }
}