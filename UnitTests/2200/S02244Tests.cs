using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02244Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02244();
        Assert.That(sut.MinimumRounds([2, 2, 3, 3, 2, 4, 4, 4, 4, 4]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02244();
        Assert.That(sut.MinimumRounds([2, 3, 3]), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02244();
        Assert.That(sut.MinimumRounds([2]), Is.EqualTo(-1));
    }

    [Test]
    public void T4()
    {
        var sut = new S02244();
        Assert.That(sut.MinimumRounds([1, 2, 1]), Is.EqualTo(-1));
    }
}