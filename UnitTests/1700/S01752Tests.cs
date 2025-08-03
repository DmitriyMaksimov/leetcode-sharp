using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01752Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01752();
        Assert.That(sut.Check([3, 4, 5, 1, 2]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01752();
        Assert.That(sut.Check([2, 1, 3, 4]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01752();
        Assert.That(sut.Check([1, 2, 3]), Is.True);
    }
}
