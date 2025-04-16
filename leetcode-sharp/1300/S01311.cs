namespace leetcode_sharp;

// 1311. Get Watched Videos by Your Friends
// https://leetcode.com/problems/get-watched-videos-by-your-friends
public class S01311
{
    public IList<string> WatchedVideosByFriends(IList<IList<string>> watchedVideos, int[][] friends, int id, int level)
    {
        var visited = new bool[friends.Length];
        visited[id] = true;

        var queue = new List<int> { id };

        for (var k = 0; k < level; k++)
        {
            var newQueue = new List<int>();
            foreach (var v in queue)
            {
                foreach (var w in friends[v])
                {
                    if (!visited[w])
                    {
                        visited[w] = true;
                        newQueue.Add(w);
                    }
                }
            }

            queue = newQueue;
        }

        var freq = new Dictionary<string, int>();

        foreach (var person in queue)
        {
            foreach (var video in watchedVideos[person])
            {
                freq[video] = freq.GetValueOrDefault(video) + 1;
            }
        }

        var result = freq.Keys.ToList();

        result.Sort((a, b) =>
        {
            var freqA = freq[a];
            var freqB = freq[b];
            return freqA != freqB ? freqA.CompareTo(freqB) : string.Compare(a, b, StringComparison.Ordinal);
        });

        return result;
    }
}
