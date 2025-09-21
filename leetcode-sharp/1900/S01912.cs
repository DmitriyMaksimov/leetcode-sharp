namespace leetcode_sharp;

// 1912. Design Movie Rental System
// https://leetcode.com/problems/design-movie-rental-system
public class S01912
{
    public class MovieRentingSystem
    {
        private readonly Dictionary<int, SortedSet<Entry>> _unrented = new();
        private readonly Dictionary<(int shop, int movie), int> _price = new();
        private readonly SortedSet<Entry> _rented;

        public MovieRentingSystem(int n, int[][] entries)
        {
            _rented = new SortedSet<Entry>(new EntryComparer());

            foreach (var entry in entries)
            {
                var shop = entry[0];
                var movie = entry[1];
                var price = entry[2];

                var newEntry = new Entry(price, shop, movie);

                if (!_unrented.TryGetValue(movie, out var set))
                {
                    set = new SortedSet<Entry>(new EntryComparer());
                    _unrented[movie] = set;
                }

                set.Add(newEntry);
                _price[(shop, movie)] = price;
            }
        }

        public List<int> Search(int movie)
        {
            return _unrented.TryGetValue(movie, out var set)
                ? set.Take(5).Select(e => e.Shop).ToList()
                : [];
        }

        public void Rent(int shop, int movie)
        {
            var price = _price[(shop, movie)];
            var entry = new Entry(price, shop, movie);

            _unrented[movie].Remove(entry);
            _rented.Add(entry);
        }

        public void Drop(int shop, int movie)
        {
            var price = _price[(shop, movie)];
            var entry = new Entry(price, shop, movie);

            _unrented[movie].Add(entry);
            _rented.Remove(entry);
        }

        public List<List<int>> Report()
        {
            return _rented.Take(5)
                .Select(e => new List<int> { e.Shop, e.Movie })
                .ToList();
        }

        private record Entry(int Price, int Shop, int Movie);

        private class EntryComparer : IComparer<Entry>
        {
            public int Compare(Entry? x, Entry? y)
            {
                if (x is null || y is null)
                {
                    return 0;
                }

                var priceComparison = x.Price.CompareTo(y.Price);
                if (priceComparison != 0)
                {
                    return priceComparison;
                }

                var shopComparison = x.Shop.CompareTo(y.Shop);
                if (shopComparison != 0)
                {
                    return shopComparison;
                }

                return x.Movie.CompareTo(y.Movie);
            }
        }
    }
}