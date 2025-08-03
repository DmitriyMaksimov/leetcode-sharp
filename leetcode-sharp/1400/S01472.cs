namespace leetcode_sharp;

// 1472. Design Browser History
// https://leetcode.com/problems/design-browser-history/
public abstract class S01472
{
    public class BrowserHistory
    {
        private readonly List<string> _history = [];
        private int _currentIndex;

        private int Count => _history.Count;
        
        public BrowserHistory(string homepage)
        {
            _history.Add(homepage);
            _currentIndex = 0;
        }

        public void Visit(string url)
        {
            if (_currentIndex < Count - 1)
            {
                _history.RemoveRange(_currentIndex + 1, Count - _currentIndex - 1);
            }
            
            _history.Add(url);
            _currentIndex = Count - 1;
        }

        public string Back(int steps)
        {
            _currentIndex = Math.Max(_currentIndex - steps, 0);
            return _history[_currentIndex];
        }

        public string Forward(int steps)
        {
            _currentIndex = Math.Min(_currentIndex + steps, Count - 1);
            return _history[_currentIndex];
        }
    }
}