namespace leetcode_sharp;

// 528. Random Pick with Weight
// https://leetcode.com/problems/random-pick-with-weight/description/
public static class S00528
{
    public class Solution
    {
        private readonly int[] _prefix;
        private readonly int _total;
        private static readonly Random Rand = new();

        public Solution(int[] w)
        {
            _prefix = new int[w.Length];

            for (var i = 0; i < w.Length; i++)
            {
                _total += w[i];
                _prefix[i] = _total;
            }
        }

        public int PickIndex()
        {
            var target = Rand.Next(_total);
            var index = Array.BinarySearch(_prefix, target + 1); // +1 ensures we get the upper bound

            if (index < 0)
            {
                index = ~index;
            }
            
            return index;
        }
    }
}