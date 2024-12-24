namespace leetcode_sharp;

// 911. Online Election
// https://leetcode.com/problems/online-election
public static class S00911
{
    public class TopVotedCandidate
    {
        private readonly Dictionary<int, int> _timeToLeader = [];
        private readonly int[] _times;

        public TopVotedCandidate(int[] persons, int[] times)
        {
            var lead = persons[0];
            var count = new Dictionary<int, int>();
            _times = times;

            for (var i = 0; i < persons.Length; i++)
            {
                count[persons[i]] = count.GetValueOrDefault(persons[i]) + 1;

                if (count[persons[i]] >= count[lead])
                {
                    lead = persons[i];
                }

                _timeToLeader[times[i]] = lead;
            }
        }

        public int Q(int t)
        {
            var index = Array.BinarySearch(_times, t);

            return index < 0 ? _timeToLeader[_times[~index - 1]] : _timeToLeader[_times[index]];
        }
    }
}
