namespace leetcode_sharp;

// 1276. Number of Burgers with No Waste of Ingredients
// https://leetcode.com/problems/number-of-burgers-with-no-waste-of-ingredients
public class S01276
{
    public IList<int> NumOfBurgers(int tomatoSlices, int cheeseSlices)
    {
        var twoX = tomatoSlices - 2 * cheeseSlices;
        var x = twoX / 2;
        var y = cheeseSlices - x;

        return twoX >= 0 && twoX % 2 == 0 && y >= 0 ? new List<int> { x, y } : new List<int>();
    }
}
