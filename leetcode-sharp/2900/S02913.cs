namespace leetcode_sharp;

// 2913. Subarrays Distinct Element Sum of Squares I
// https://leetcode.com/problems/subarrays-distinct-element-sum-of-squares-i
public class S02913
{
    public int SumCounts(IList<int> nums)
    {
        var result = 0;
        
        for (var i = 0; i < nums.Count; i++)
        {
            var hs = new HashSet<int>();
            
            for (var j = i; j < nums.Count; j++)
            {
                hs.Add(nums[j]);
                result += hs.Count * hs.Count;
            }
        }

        return result;
    }
}