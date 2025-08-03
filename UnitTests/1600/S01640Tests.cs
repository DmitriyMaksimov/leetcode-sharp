using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01640Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01640();
        Assert.That(sut.CanFormArray([15, 88], [[88], [15]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01640();
        Assert.That(sut.CanFormArray([49, 18, 16], [[16, 18, 49]]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01640();
        Assert.That(sut.CanFormArray([91, 4, 64, 78], [[78], [4, 64], [91]]), Is.True);
    }
}
