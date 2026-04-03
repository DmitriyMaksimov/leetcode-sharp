using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03661))]
public class S03661Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03661();
        Assert.That(sut.MaxWalls([4], [3], [1, 10]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03661();
        Assert.That(sut.MaxWalls([10, 2], [5, 1], [5, 2, 7]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03661();
        Assert.That(sut.MaxWalls([1, 2], [100, 1], [10]), Is.Zero);
    }
}