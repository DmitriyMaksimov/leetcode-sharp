using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01653Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01653();
        Assert.That(sut.MinimumDeletions("aababbab"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01653();
        Assert.That(sut.MinimumDeletions("bbaaaaabb"), Is.EqualTo(2));
    }
}