namespace leetcode_sharp;

// 1346. Check If N and Its Double Exist
// https://leetcode.com/problems/check-if-n-and-its-double-exist/
public class S01346
{
    public bool CheckIfExist(int[] arr)
    {
        var hashSet = new HashSet<int>();
        
        foreach (var n in arr)
        {
            if (hashSet.Contains(n * 2) || ( (n % 2) == 0 && hashSet.Contains(n / 2)))
            {
                return true;
            }

            hashSet.Add(n);
        }

        return false;
    }
}