using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02079Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02079();
        Assert.That(sut.WateringPlants(new[] {2, 2, 3, 3}, 5), Is.EqualTo(14));
    }

    [Test]
    public void T2()
    {
        var sut = new S02079();
        Assert.That(sut.WateringPlants(new[] {1, 1, 1, 4, 2, 3}, 4), Is.EqualTo(30));
    }

    [Test]
    public void T3()
    {
        var sut = new S02079();
        Assert.That(sut.WateringPlants(new[] {7, 7, 7, 7, 7, 7, 7}, 8), Is.EqualTo(49));
    }
}