namespace leetcode_sharp;

// 350. Intersection of Two Arrays II
// https://leetcode.com/problems/intersection-of-two-arrays-ii/
public class S00350
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var intersection = new Dictionary<int, int>();
        var shortArray = nums1.Length < nums2.Length ? nums1 : nums2;
        var longArray = nums1.Length < nums2.Length ? nums2 : nums1;
        
        foreach (var n in shortArray)
        {
            intersection[n] = intersection.GetValueOrDefault(n) + 1;
        }

        var result = new List<int>();
        
        foreach (var n in longArray)
        {
            if (intersection.TryGetValue(n, out var count) && count > 0)
            {
                result.Add(n);
                intersection[n] = count - 1;
            }
        }

        return result.ToArray();
    }
}