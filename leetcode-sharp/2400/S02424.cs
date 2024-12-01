namespace leetcode_sharp;

// 2424. Longest Uploaded Prefix
// https://leetcode.com/problems/longest-uploaded-prefix
public static class S02424
{
    public class LUPrefix
    {
        private readonly HashSet<int> _uploadedVideos = [];
        private int _longestPrefix;

        public LUPrefix(int n)
        {
        }

        public void Upload(int video)
        {
            _uploadedVideos.Add(video);
        }

        public int Longest()
        {
            while (_uploadedVideos.Contains(_longestPrefix + 1))
            {
                _longestPrefix++;
            }

            return _longestPrefix;
        }
    }
}
