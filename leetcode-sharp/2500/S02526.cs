namespace leetcode_sharp;

// 2526. Find Consecutive Integers from a Data Stream
// https://leetcode.com/problems/find-consecutive-integers-from-a-data-stream
public static class S02526
{
    public class DataStream
    {
        private readonly int _value;
        private readonly int _kMax;
        private int _valCount;

        public DataStream(int value, int k)
        {
            _value = value;
            _kMax = k;
        }

        public bool Consec(int num)
        {
            _valCount = num == _value ? _valCount + 1 : 0;

            return _valCount >= _kMax;
        }
    }
}
