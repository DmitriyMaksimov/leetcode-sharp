using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03531))]
public class S03531Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03531();
        Assert.That(sut.CountCoveredBuildings(3, [[1, 2], [2, 2], [3, 2], [2, 1], [2, 3]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03531();
        Assert.That(sut.CountCoveredBuildings(3, [[1, 1], [1, 2], [2, 1], [2, 2]]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03531();
        Assert.That(sut.CountCoveredBuildings(5, [[1, 3], [3, 2], [3, 3], [3, 5], [5, 3]]), Is.EqualTo(1));
    }
}