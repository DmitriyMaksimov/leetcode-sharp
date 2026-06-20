using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01840))]
public class S01840Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01840();
        Assert.That(sut.MaxBuilding(5, [[2, 1], [4, 1]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01840();
        Assert.That(sut.MaxBuilding(6, []), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S01840();
        Assert.That(sut.MaxBuilding(10, [[5, 3], [2, 5], [7, 4], [10, 3]]), Is.EqualTo(5));
    }
}