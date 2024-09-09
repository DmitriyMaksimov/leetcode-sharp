namespace leetcode_sharp;

// 1237. Find Positive Integer Solution for a Given Equation
// https://leetcode.com/problems/find-positive-integer-solution-for-a-given-equation
public class S01237
{
    // This is the custom function interface.
    // You should not implement it, or speculate about its implementation
    public abstract class CustomFunction
    {
        // Returns f(x, y) for any given positive integers x and y.
        // Note that f(x, y) is increasing with respect to both x and y.
        // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
        public abstract int f(int x, int y);
    };

    public IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
    {
        IList<IList<int>> result = [];
        var x = 1;
        var y = 1000;

        while (x <= 1000 && y > 0)
        {
            var v = customfunction.f(x, y);
            if (v > z)
            {
                --y;
            }
            else if (v < z)
            {
                ++x;
            }
            else
            {
                result.Add([x++, y--]);
            }
        }

        return result;
    }
}
