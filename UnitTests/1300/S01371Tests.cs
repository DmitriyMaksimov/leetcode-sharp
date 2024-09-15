using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01371Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01371();
        sut.FindTheLongestSubstring("eleetminicoworoep").Should().Be(13);
    }

    [Test]
    public void T2()
    {
        var sut = new S01371();
        sut.FindTheLongestSubstring("leetcodeisgreat").Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01371();
        sut.FindTheLongestSubstring("bcbcbc").Should().Be(6);
    }
}
