namespace leetcode_sharp;

// 3477. Fruits Into Baskets II
// https://leetcode.com/problems/fruits-into-baskets-ii
public class S03477
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        var unplaced = 0;

        foreach (var fruitQuantity in fruits)
        {
            var foundBucket = false;

            for (var j = 0; j < baskets.Length; j++)
            {
                if (fruitQuantity <= baskets[j])
                {
                    baskets[j] = 0;
                    foundBucket = true;
                    break;
                }
            }

            if (!foundBucket)
            {
                unplaced++;
            }
        }

        return unplaced;
    }
}
