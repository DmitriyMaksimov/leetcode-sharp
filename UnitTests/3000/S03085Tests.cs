using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03085))]
public class S03085Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03085();
        Assert.That(sut.MinimumDeletions("aabcaba", 0), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03085();
        Assert.That(sut.MinimumDeletions("dabdcbdcdcd", 2), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03085();
        Assert.That(sut.MinimumDeletions("aaabaaa", 2), Is.EqualTo(1));
    }
}