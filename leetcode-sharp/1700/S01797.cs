namespace leetcode_sharp;

// 1797. Design Authentication Manager
// https://leetcode.com/problems/design-authentication-manager
public static class S01797
{
    public class AuthenticationManager
    {
        private readonly int _ttl;
        private readonly SortedSet<(int time, string tokenId)> _timeMap = [];
        private readonly Dictionary<string, int> _tokenMap = [];

        public AuthenticationManager(int timeToLive)
        {
            _ttl = timeToLive;
        }

        public void Generate(string tokenId, int currentTime)
        {
            var expiryTime = currentTime + _ttl;
            _tokenMap[tokenId] = expiryTime;
            _timeMap.Add((expiryTime, tokenId));
        }

        public void Renew(string tokenId, int currentTime)
        {
            Clean(currentTime);

            if (!_tokenMap.TryGetValue(tokenId, out var expiryTime) || expiryTime <= currentTime)
            {
                return;
            }

            _timeMap.Remove((expiryTime, tokenId));
            expiryTime = currentTime + _ttl;
            _tokenMap[tokenId] = expiryTime;
            _timeMap.Add((expiryTime, tokenId));
        }

        public int CountUnexpiredTokens(int currentTime)
        {
            Clean(currentTime);
            return _tokenMap.Count;
        }

        private void Clean(int currentTime)
        {
            while (_timeMap.Count > 0 && _timeMap.Min.time <= currentTime)
            {
                var expiredToken = _timeMap.Min;
                _tokenMap.Remove(expiredToken.tokenId);
                _timeMap.Remove(expiredToken);
            }
        }
    }
}
