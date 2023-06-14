namespace leetcode_sharp;

// 1656. Design an Ordered Stream
// https://leetcode.com/problems/design-an-ordered-stream/
public static class S01656
{
    public class OrderedStream
    {
        private readonly string?[] _data;
        private int _ptr;

        public OrderedStream(int n)
        {
            _data = new string[n + 1];
            _ptr = 1;
        }

        public IList<string> Insert(int idKey, string value)
        {
            _data[idKey] = value;
            var res = new List<string>();
            for (var i = _ptr; i < _data.Length; i++)
            {
                if (_data[i] != null)
                {
                    res.Add(_data[i]!);
                }
                else
                {
                    _ptr = i;
                    break;
                }
            }

            return res;
        }
    }
}