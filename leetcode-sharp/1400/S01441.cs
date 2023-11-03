namespace leetcode_sharp;

// 1441. Build an Array With Stack Operations
// https://leetcode.com/problems/build-an-array-with-stack-operations
public class S01441
{
    public IList<string> BuildArray(int[] target, int n)
    {
        var targetSet = new HashSet<int>(target);
        var result = new List<string>();

        for (var i = 1; i <= target[^1]; i++)
        {
            if (targetSet.Contains(i))
            {
                result.Add("Push");
            }
            else
            {
                result.Add("Push");
                result.Add("Pop");
            }
        }

        return result;
    }
}