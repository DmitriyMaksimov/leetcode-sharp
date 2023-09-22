namespace leetcode_sharp;

// 2404. Most Frequent Even Element 
// https://leetcode.com/problems/most-frequent-even-element/
public class S02404
{
    public int MostFrequentEven(int[] nums)
    {
        var dictionary = new Dictionary<int, int>();
        foreach (var num in nums.Where(n => n % 2 == 0))
        {
            dictionary[num] = dictionary.GetValueOrDefault(num) + 1;
        }
        
        return dictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key).FirstOrDefault(new KeyValuePair<int, int>(-1,0)).Key; 
    }
}