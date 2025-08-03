using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02784Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02784();
        Assert.That(sut.IsGood([2, 1, 3]), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S02784();
        Assert.That(sut.IsGood([1, 3, 3, 2]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S02784();
        Assert.That(sut.IsGood([1, 1]), Is.True);
    }

    [Test]
    public void T4()
    {
        var sut = new S02784();
        Assert.That(sut.IsGood([3, 4, 4, 1, 2, 1]), Is.False);
    }
}
