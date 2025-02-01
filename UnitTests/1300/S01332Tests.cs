using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01332Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01332();
        Assert.That(sut.RemovePalindromeSub("ababa"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01332();
        Assert.That(sut.RemovePalindromeSub("abb"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01332();
        Assert.That(sut.RemovePalindromeSub("baabb"), Is.EqualTo(2));
    }
}