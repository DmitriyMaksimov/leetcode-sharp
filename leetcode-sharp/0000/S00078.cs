namespace leetcode_sharp;

// 78. Subsets

// https://leetcode.com/problems/subsets/
public class S00078
{
    private int[] _nums = null!;
    private int _totalElements;

    public IList<IList<int>> Subsets(int[] nums)
    {
        _nums = nums;

        IList<IList<int>> result = new List<IList<int>>();

        _totalElements = 1 << nums.Length;

        for (var i = 0; i < _totalElements; i++)
        {
            result.Add(bitmaskToList(i));
        }
        
        return result;
    }

    private IList<int> bitmaskToList(int n)
    {
        var result = new List<int>();
        var currentBit = 1;

        for (var i = 0; i < _totalElements; i++)
        {
            if ((n & currentBit) != 0)
            {
                result.Add(_nums[i]);
            }

            currentBit <<= 1;
        }

        return result;
    }
}