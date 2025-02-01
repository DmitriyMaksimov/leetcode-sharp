using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01328Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01328();
        Assert.That(sut.BreakPalindrome("abccba"), Is.EqualTo("aaccba"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01328();
        Assert.That(sut.BreakPalindrome("a"), Is.EqualTo(""));
    }
}
