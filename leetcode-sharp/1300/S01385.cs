namespace leetcode_sharp;

// 1385. Find the Distance Value Between Two Arrays
// https://leetcode.com/problems/find-the-distance-value-between-two-arrays/
public class S01385
{
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        return arr1.Select(a => arr2.All(b => Math.Abs(a - b) > d)).Count(meetCriteria => meetCriteria);
    }
}