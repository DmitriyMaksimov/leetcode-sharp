using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03131Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03131();
        Assert.That(sut.AddedInteger([2, 6, 4], [9, 7, 5]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03131();
        Assert.That(sut.AddedInteger([10], [5]), Is.EqualTo(-5));
    }

    [Test]
    public void T3()
    {
        var sut = new S03131();
        Assert.That(sut.AddedInteger([1, 1, 1, 1], [1, 1, 1, 1]), Is.EqualTo(0));
    }
}