using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02353Tests
{
    [Test]
    public void T1()
    {
        var foodRatings = new S02353.FoodRatings(["kimchi", "miso", "sushi", "moussaka", "ramen", "bulgogi"],
            ["korean", "japanese", "japanese", "greek", "japanese", "korean"], [9, 12, 8, 15, 14, 7]);
        Assert.That(foodRatings.HighestRated("korean"), Is.EqualTo("kimchi")); // "kimchi" is the highest rated korean food with a rating of 9.
        Assert.That(foodRatings.HighestRated("japanese"), Is.EqualTo("ramen")); // "ramen" is the highest rated japanese food with a rating of 14.
        foodRatings.ChangeRating("sushi", 16); // "sushi" now has a rating of 16.
        Assert.That(foodRatings.HighestRated("japanese"), Is.EqualTo("sushi")); // "sushi" is the highest rated japanese food with a rating of 16.
        foodRatings.ChangeRating("ramen", 16); // "ramen" now has a rating of 16.
        Assert.That(foodRatings.HighestRated("japanese"), Is.EqualTo("ramen")); // Both "sushi" and "ramen" have a rating of 16. However, "ramen" is lexicographically smaller than "sushi".
    }
}