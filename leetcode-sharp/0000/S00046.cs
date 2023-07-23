namespace leetcode_sharp;

// 46. Permutations
// https://leetcode.com/problems/permutations/
public class S00046
{
    public IList<IList<int>> Permute(int[] nums)
    {
        if (nums.Length == 1)
        {
            return new List<IList<int>> {new List<int> {nums[0]}};
        }
        return permutations(nums.ToList()).ToList();
    }

    private static IEnumerable<IList<int>> permutations(List<int> nums)
    {
        if (nums.Count == 2)
        {
            yield return new List<int> {nums[0], nums[1]}; 
            yield return new List<int> {nums[1], nums[0]}; 
        }
        else
        {
            foreach (var elem in nums)
            {
                var subList = new List<int>(nums);
                subList.Remove(elem);
                foreach(var ret in permutations(subList))
                {
                    ret.Insert(0, elem);
                    yield return ret;
                }
            }
        }
    }
}