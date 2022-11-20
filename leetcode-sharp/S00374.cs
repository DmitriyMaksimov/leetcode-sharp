namespace leetcode_sharp;

// 374. Guess Number Higher or Lower
// https://leetcode.com/problems/guess-number-higher-or-lower/
public class S00374
{
    private readonly Func<int, int> guess;

    public S00374(Func<int, int> guess)
    {
        this.guess = guess;
    }
    /** 
     * Forward declaration of guess API.
     * @param  num   your guess
     * @return 	     -1 if num is higher than the picked number
     *			      1 if num is lower than the picked number
     *               otherwise return 0
     * int guess(int num);
     */
    
    public int GuessNumber(int n)
    {
        var l = 1;
        var h = n;
        
        while (true)
        {
            var mid = l + (h - l) / 2;
            var g = guess(mid);
            switch (g)
            {
                case -1: h = mid - 1; break;
                case 1: l = mid + 1; break;
                case 0: return mid;
            }
        }
    }
}