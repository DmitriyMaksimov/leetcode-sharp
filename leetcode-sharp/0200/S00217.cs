namespace leetcode_sharp;

// 217. Contains Duplicate
// https://leetcode.com/problems/contains-duplicate/
public class S00217
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hashSet = new HashSet<int>();

        foreach (var num in nums)
        {
            if (hashSet.Contains(num))
            {
                return true;
            }

            hashSet.Add(num);
        }
        
        return false;
    }
}