namespace leetcode_sharp;

// 933. Number of Recent Calls
// https://leetcode.com/problems/number-of-recent-calls/
public static class S00933
{
    public class RecentCounter
    {
        private readonly List<int> _calls = new();

        public int Ping(int t)
        {
            _calls.Add(t);
            return _calls.Count(call => t - call <= 3000);
        }
    }
}