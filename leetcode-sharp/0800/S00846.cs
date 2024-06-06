namespace leetcode_sharp;

// 846. Hand of Straights
// https://leetcode.com/problems/hand-of-straights
public class S00846
{
    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        if (hand.Length % groupSize != 0)
        {
            return false;
        }

        var list = hand.Order().ToList();

        while (list.Count >= groupSize)
        {
            var current = list[0];
            var len = 1;
            var j = 1;

            while (j < list.Count && len < groupSize)
            {
                if (list[j] < current + 1)
                {
                    j++;
                }
                else if (list[j] == current + 1)
                {
                    current++;
                    len++;
                    list.RemoveAt(j);
                    j--;
                }
                else
                {
                    return false;
                }
            }

            if (len == groupSize)
            {
                list.RemoveAt(0);
            }
            else
            {
                return false;
            }
        }

        return list.Count == 0;
    }
}