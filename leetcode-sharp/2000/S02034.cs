namespace leetcode_sharp;

// 2034. Stock Price Fluctuation
// https://leetcode.com/problems/stock-price-fluctuation
public static class S02034
{
public class StockPrice
{
    private int _highestTimestamp;
    private readonly Dictionary<int, int> _timestamps = new();
    private readonly PriorityQueue<(int price, int timestamp), int> _minHeap = new();
    private readonly PriorityQueue<(int price, int timestamp), int> _maxHeap = new();

    public void Update(int timestamp, int price)
    {
        _timestamps[timestamp] = price;
        _highestTimestamp = Math.Max(_highestTimestamp, timestamp);

        _minHeap.Enqueue((price, timestamp), price);
        _maxHeap.Enqueue((price, timestamp), -price);
    }

    public int Current()
    {
        return _timestamps[_highestTimestamp];
    }

    public int Maximum()
    {
        while (_maxHeap.Count > 0)
        {
            var (price, timestamp) = _maxHeap.Peek();
            if (_timestamps.TryGetValue(timestamp, out var currentPrice) && currentPrice == price)
            {
                return price;
            }

            _maxHeap.Dequeue();
        }

        return -1;
    }

    public int Minimum()
    {
        while (_minHeap.Count > 0)
        {
            var (price, timestamp) = _minHeap.Peek();
            if (_timestamps.TryGetValue(timestamp, out var currentPrice) && currentPrice == price)
            {
                return price;
            }

            _minHeap.Dequeue();
        }

        return -1;
    }
}
}
