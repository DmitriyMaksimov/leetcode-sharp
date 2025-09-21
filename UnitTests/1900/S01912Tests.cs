using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01912))]
public class S01912Tests
{
    [Test]
    public void T1()
    {
        var movieRentingSystem = new S01912.MovieRentingSystem(3, [[0, 1, 5], [0, 2, 6], [0, 3, 7], [1, 1, 4], [1, 2, 7], [2, 1, 5]]);
        Assert.That(movieRentingSystem.Search(1), Is.EqualTo([1, 0, 2])); // return [1, 0, 2], Movies of ID 1 are unrented at shops 1, 0, and 2. Shop 1 is cheapest; shop 0 and 2 are the same price, so order by shop number.
        movieRentingSystem.Rent(0, 1); // Rent movie 1 from shop 0. Unrented movies at shop 0 are now [2,3].
        movieRentingSystem.Rent(1, 2); // Rent movie 2 from shop 1. Unrented movies at shop 1 are now [1].
        Assert.That(movieRentingSystem.Report(), Is.EqualTo([(int[])[0, 1], [1, 2]])); // return [[0, 1], [1, 2]]. Movie 1 from shop 0 is cheapest, followed by movie 2 from shop 1.
        movieRentingSystem.Drop(1, 2); // Drop off movie 2 at shop 1. Unrented movies at shop 1 are now [1,2].
        Assert.That(movieRentingSystem.Search(2), Is.EqualTo([0, 1])); // return [0, 1]. Movies of ID 2 are unrented at shops 0 and 1. Shop 0 is cheapest, followed by shop 1.
    }
}