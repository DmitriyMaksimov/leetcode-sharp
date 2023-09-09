namespace leetcode_sharp;

// 1460. Make Two Arrays Equal by Reversing Sub-arrays
// https://leetcode.com/problems/make-two-arrays-equal-by-reversing-sub-arrays/
public class S01460
{
    public bool CanBeEqual(int[] target, int[] arr)
    {
        var targetMap = new Dictionary<int, int>();
        var arrMap = new Dictionary<int, int>();

        foreach (var i in target)
        {
            targetMap[i] = targetMap.GetValueOrDefault(i) + 1;
        }

        foreach (var i in arr)
        {
            arrMap[i] = arrMap.GetValueOrDefault(i) + 1;
        }

        return targetMap.All(i => arrMap.ContainsKey(i.Key) && arrMap[i.Key] == i.Value);
    }
}