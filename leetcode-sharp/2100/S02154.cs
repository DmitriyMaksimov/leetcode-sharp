namespace leetcode_sharp;

// 2154. Keep Multiplying Found Values by Two
// https://leetcode.com/problems/keep-multiplying-found-values-by-two/
public class S02154
{
    public int FindFinalValue(int[] nums, int original)
    {
        var hashSet = new HashSet<int>(nums);

        var valid = true;

        while (valid)
        {
            if (hashSet.Contains(original))
            {
                valid = true;
                original *= 2;
            }
            else
            {
                valid = false;
            }
        }

        return original;
    }
}