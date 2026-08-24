using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01872))]
public class S01872Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01872();
        Assert.That(sut.StoneGameVIII([-1, 2, -3, 4, -5]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01872();
        Assert.That(sut.StoneGameVIII([7, -6, 5, 10, 5, -2, -6]), Is.EqualTo(13));
    }

    [Test]
    public void T3()
    {
        var sut = new S01872();
        Assert.That(sut.StoneGameVIII([-10, -12]), Is.EqualTo(-22));
    }
}