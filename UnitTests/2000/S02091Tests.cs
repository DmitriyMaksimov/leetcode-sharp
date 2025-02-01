using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02091Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02091();
        Assert.That(sut.MinimumDeletions([2, 10, 7, 5, 4, 1, 8, 6]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02091();
        Assert.That(sut.MinimumDeletions([0, -4, 19, 1, 8, -2, -3, 5]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02091();
        Assert.That(sut.MinimumDeletions([101]), Is.EqualTo(1));
    }
}
