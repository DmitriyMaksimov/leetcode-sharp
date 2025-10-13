namespace leetcode_sharp;

// 2248. Intersection of Multiple Arrays
// https://leetcode.com/problems/intersection-of-multiple-arrays/
public class S02248
{
    public IList<int> Intersection(int[][] nums)
    {
        var counts = new Dictionary<int, int>();
        
        foreach (var arr in nums)
        {
            foreach (var n in arr)
            {
                counts[n] = counts.GetValueOrDefault(n) + 1;
            }
        }
        
        return counts.Where(x => x.Value == nums.Length).Select(x => x.Key).Order().ToArray();
    }
}