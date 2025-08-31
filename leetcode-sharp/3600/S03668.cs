namespace leetcode_sharp;

// 3668. Restore Finishing Order
// https://leetcode.com/problems/restore-finishing-order
public class S03668
{
    public int[] RecoverOrder(int[] order, int[] friends)
    {
        var friendsSet = friends.ToHashSet();
        
        return order.Where(x => friendsSet.Contains(x)).ToArray();
    }
}