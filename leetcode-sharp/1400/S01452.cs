namespace leetcode_sharp;

// 1452. People Whose List of Favorite Companies Is Not a Subset of Another List
// https://leetcode.com/problems/people-whose-list-of-favorite-companies-is-not-a-subset-of-another-list
public class S01452
{
    public IList<int> PeopleIndexes(IList<IList<string>> favoriteCompanies)
    {
        var result = new List<int>();
        var companies = favoriteCompanies.Select(list => (HashSet<string>) [..list]).ToList();

        for (var i = 0; i < companies.Count; i++)
        {
            var isSubset = companies.Where((_, j) => i != j).Any(company => company.IsSupersetOf(companies[i]));

            if (!isSubset)
            {
                result.Add(i);
            }
        }

        return result;
    }
}
