namespace leetcode_sharp;

// 2032. Two Out of Three
// https://leetcode.com/problems/two-out-of-three/
public class S02032
{
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        var result = new HashSet<int>();
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        var set3 = new HashSet<int>(nums3);

        foreach (var num in set1.Where(num => set2.Contains(num) || set3.Contains(num)))
        {
            result.Add(num);
        }

        foreach (var num in set2.Where(num => set1.Contains(num) || set3.Contains(num)))
        {
            result.Add(num);
        }

        foreach (var num in set3.Where(num => set1.Contains(num) || set2.Contains(num)))
        {
            result.Add(num);
        }

        return result.ToArray();
    }
}