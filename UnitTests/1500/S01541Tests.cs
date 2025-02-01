using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01541Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01541();
        Assert.That(sut.MinInsertions("(()))"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01541();
        Assert.That(sut.MinInsertions("())"), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01541();
        Assert.That(sut.MinInsertions("))())("), Is.EqualTo(3));
    }
}
