namespace leetcode_sharp;

// 347. Top K Frequent Elements
// https://leetcode.com/problems/top-k-frequent-elements/
public class S00347
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dictionary = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            dictionary[num] = dictionary.GetValueOrDefault(num, 0) + 1;
        }
        
        return dictionary.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}