using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01395Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01395();
        Assert.That(sut.NumTeams([2, 5, 3, 4, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01395();
        Assert.That(sut.NumTeams([2, 1, 3]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01395();
        Assert.That(sut.NumTeams([1, 2, 3, 4]), Is.EqualTo(4));
    }
}