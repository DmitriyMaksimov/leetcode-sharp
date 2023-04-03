namespace leetcode_sharp;

// 2300. Successful Pairs of Spells and Potions
// https://leetcode.com/problems/successful-pairs-of-spells-and-potions/
public class S02300
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        var sortedPotions = potions.OrderBy(x => x).Select(x => (long)x).ToList();

        var result = new int[spells.Length];

        for (var i = 0; i < spells.Length; i++)
        {
            var spell = spells[i];
            var minPotion = (success + spell - 1) / spell;
            var index = findFirst(sortedPotions, minPotion);

            result[i] = index >= sortedPotions.Count ? 0 : sortedPotions.Count - index;
        }

        return result;
    }

    private static int findFirst(IReadOnlyList<long> list, long key)
    {
        var low = 0;
        var high = list.Count - 1;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;
            long midVal = list[mid];

            if (midVal < key)
            {
                low = mid + 1;
            }
            else if (midVal > key)
            {
                high = mid - 1;
            }
            else if (low != mid) //Equal but range is not fully scanned
            {
                high = mid; //Set upper bound to current number and rescan
            }
            else //Equal and full range is scanned
            {
                return mid;
            }
        }

        return low;
    }
}