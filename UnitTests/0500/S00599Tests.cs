using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00599Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00599();
        Assert.That(sut.FindRestaurant(["Shogun", "Tapioca Express", "Burger King", "KFC"],
            ["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"]), Is.EqualTo((string[]) ["Shogun"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00599();
        Assert.That(sut.FindRestaurant(["Shogun", "Tapioca Express", "Burger King", "KFC"],
            ["KFC", "Shogun", "Burger King"]), Is.EqualTo((string[]) ["Shogun"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00599();
        Assert.That(sut.FindRestaurant(["happy", "sad", "good"], ["sad", "happy", "good"]), Is.EqualTo((string[]) ["happy", "sad"]));
    }
}
