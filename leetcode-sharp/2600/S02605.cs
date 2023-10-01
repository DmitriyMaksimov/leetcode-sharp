namespace leetcode_sharp;

// 2605. Form Smallest Number From Two Digit Arrays
// https://leetcode.com/problems/form-smallest-number-from-two-digit-arrays
public class S02605
{
    public int MinNumber(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        var intersect = set1.Intersect(set2);

        if (intersect.Any())
        {
            return intersect.Min();
        }

        var digit1 = set1.Min();
        var digit2 = set2.Min();

        return digit1 < digit2 ? digit1 * 10 + digit2 : digit2 * 10 + digit1;
    }
}