namespace leetcode_sharp;

// 2766. Relocate Marbles
// https://leetcode.com/problems/relocate-marbles
public class S02766
{
    public IList<int> RelocateMarbles(int[] nums, int[] moveFrom, int[] moveTo)
    {
        var sortedSet = new SortedSet<int>(nums);

        for (var i = 0; i < moveFrom.Length; i++)
        {
            sortedSet.Remove(moveFrom[i]);
            sortedSet.Add(moveTo[i]);
        }

        return sortedSet.ToList();
    }
}
