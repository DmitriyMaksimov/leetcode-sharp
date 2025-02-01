using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01371Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01371();
        Assert.That(sut.FindTheLongestSubstring("eleetminicoworoep"), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S01371();
        Assert.That(sut.FindTheLongestSubstring("leetcodeisgreat"), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S01371();
        Assert.That(sut.FindTheLongestSubstring("bcbcbc"), Is.EqualTo(6));
    }
}
