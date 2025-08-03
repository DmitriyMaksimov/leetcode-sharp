namespace leetcode_sharp;

// 295. Find Median from Data Stream
// https://leetcode.com/problems/find-median-from-data-stream/
public class S00295
{
    private readonly List<int> _values = [];

    public S00295()
    {
        // Nothing
    }
    
    public void AddNum(int num)
    {
        var index = _values.BinarySearch(num);
        _values.Insert((index >= 0) ? index : ~index, num);
    }
    
    public double FindMedian()
    {
        var count = _values.Count;
        var isEven = count % 2 == 0;
        var index = count / 2;

        if (isEven)
        {
            return (_values[index - 1] + _values[index]) / 2.0d;
        }

        return _values[index];
    }
}