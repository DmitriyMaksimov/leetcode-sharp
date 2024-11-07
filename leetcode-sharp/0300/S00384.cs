namespace leetcode_sharp;

// 384. Shuffle an Array
// https://leetcode.com/problems/shuffle-an-array
public static class S00384
{
    public class Solution
    {
        private readonly int[] _nums;

        public Solution(int[] nums)
        {
            _nums = nums;
        }

        public int[] Reset()
        {
            return _nums;
        }

        public int[] Shuffle()
        {
            var shuffled = new int[_nums.Length];
            _nums.CopyTo(shuffled, 0);

            for (var i = 0; i < shuffled.Length; i++)
            {
                var j = Random.Shared.Next(i, shuffled.Length);
                (shuffled[i], shuffled[j]) = (shuffled[j], shuffled[i]);
            }

            return shuffled;
        }
    }
}
