namespace leetcode_sharp;

// 706. Design HashMap
// https://leetcode.com/problems/design-hashmap
public static class S00706
{
    public class MyHashMap
    {
        private readonly Dictionary<int, int> _dictionary = new();

        public void Put(int key, int value)
        {
            _dictionary[key] = value;
        }

        public int Get(int key)
        {
            return _dictionary.GetValueOrDefault(key, -1);
        }

        public void Remove(int key)
        {
            _dictionary.Remove(key);
        }
    }
}