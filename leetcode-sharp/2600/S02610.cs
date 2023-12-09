namespace leetcode_sharp;

// 2610. Convert an Array Into a 2D Array With Conditions
// https://leetcode.com/problems/convert-an-array-into-a-2d-array-with-conditions
public class S02610
{
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        var unique = new List<HashSet<int>>();

        foreach (var item in nums)
        {
            if (!unique.Any(x => x.Add(item)))
            {
                unique.Add(new HashSet<int> {item});
            }
        }

        return unique.Select(hs => hs.ToList() as IList<int>).ToList();
    }
}