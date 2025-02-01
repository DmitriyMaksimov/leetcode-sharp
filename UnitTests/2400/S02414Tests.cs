using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02414Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02414();
        Assert.That(sut.LongestContinuousSubstring("abacaba"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02414();
        Assert.That(sut.LongestContinuousSubstring("abcde"), Is.EqualTo(5));
    }
}
