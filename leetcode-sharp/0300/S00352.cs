namespace leetcode_sharp;

// 352. Data Stream as Disjoint Intervals
// https://leetcode.com/problems/data-stream-as-disjoint-intervals/
public class S00352
{
    private List<int> _startOfIntervals = [];
    private List<int> _endOfIntervals = [];
    
    public void AddNum(int value)
    {
        if (_startOfIntervals.Count == 0)
        {
            _startOfIntervals.Add(value);
            _endOfIntervals.Add(value);
            return;
        }

        var index = _startOfIntervals.BinarySearch(value);
        if (index >= 0)
        {
            // The element exist => nothing to do here
            return;
        }
        
        // now index is index of the next element that is larger than `value`
        index = ~index;

        if (index == 0)
        {
            if (_startOfIntervals[index] == value + 1)
            {
                // Expand interval
                _startOfIntervals[index] = value;
            }
            else
            {
                // New interval
                _startOfIntervals.Insert(index, value);
                _endOfIntervals.Insert(index, value);
            }

            return;
        }

        if (index == _startOfIntervals.Count)
        {
            if (_startOfIntervals[index - 1] <= value && value <= _endOfIntervals[index - 1])
            {
                // Belongs to last interval => nothing to do here
            }
            else if (_endOfIntervals[index - 1] == value - 1)
            {
                // Expand interval
                _endOfIntervals[index - 1] = value;
            }
            else
            {
                // New interval
                _startOfIntervals.Add(value);
                _endOfIntervals.Add(value);
            }

            return;
        }

        if (value <= _endOfIntervals[index - 1])
        {
            // Belongs to previous interval => nothing to do
            return;
        }
        
        if (_endOfIntervals[index - 1] == _startOfIntervals[index] - 2)
        {
            // Merge intervals
            _endOfIntervals[index - 1] = _endOfIntervals[index];
            _startOfIntervals.RemoveAt(index);
            _endOfIntervals.RemoveAt(index);
            
            return;
        }

        if (value == _startOfIntervals[index] - 1)
        {
            // Expand next interval
            _startOfIntervals[index] = value;
            return;
        }

        if (value == _endOfIntervals[index - 1] + 1)
        {
            // Expand prev interval
            _endOfIntervals[index - 1] = value;
            return;
        }

        // Add a new interval
        _startOfIntervals.Insert(index, value);
        _endOfIntervals.Insert(index, value);
    }

    public int[][] GetIntervals()
    {
        var result = new int[_startOfIntervals.Count][];

        for (var i = 0; i < _startOfIntervals.Count; i++)
        {
            result[i] = [_startOfIntervals[i], _endOfIntervals[i]];
        }

        return result;
    }
}