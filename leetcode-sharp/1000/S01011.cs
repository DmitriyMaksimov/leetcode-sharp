namespace leetcode_sharp;

// 1011. Capacity To Ship Packages Within D Days
// https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/
public class S01011
{
    private int[] _weights = null!;
    private int _days;

    public int ShipWithinDays(int[] weights, int days)
    {
        _days = days;
        _weights = weights;

        var l = 1;
        var h = int.MaxValue;
        var currentMin = int.MaxValue;
        
        while (l <= h)
        {
            var mid = l + (h - l) / 2;

            if (possible(mid))
            {
                currentMin = Math.Min(currentMin, mid);
                h = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }

        return currentMin;
    }

    private bool possible(int capacity)
    {
        var currentSum = 0;
        var days = 1;
        
        foreach (var weight in _weights)
        {
            if (weight > capacity)
            {
                return false;
            }
            
            if (currentSum + weight > capacity)
            {
                currentSum = weight;
                ++days;

                if (days > _days)
                {
                    break;
                }
            }
            else
            {
                currentSum += weight;
            }
        }
        
        return days <= _days;
    }
}