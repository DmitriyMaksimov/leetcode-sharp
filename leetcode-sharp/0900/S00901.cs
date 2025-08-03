namespace leetcode_sharp;

// 901. Online Stock Span
// https://leetcode.com/problems/online-stock-span/
public static class S00901
{
public class StockSpanner
{
    private readonly List<int> _stockPrices = [];
    private readonly List<int> _spans = [];

    public int Next(int price)
    {
        var span = 1;
        if (_stockPrices.Count > 0)
        {
            int i;

            if (_stockPrices.Last() <= price)
            {
                span = _spans.Last() + 1;
                i = _stockPrices.Count - span;
            }
            else
            {
                i = _stockPrices.Count - 1;
            }

            while (i >= 0 && _stockPrices[i] <= price)
            {
                span++;
                i--;
            }
        }

        _stockPrices.Add(price);
        _spans.Add(span);

        return span;
    }
}
}