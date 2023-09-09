using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01332Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01332();
        sut.RemovePalindromeSub("ababa").Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01332();
        sut.RemovePalindromeSub("abb").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01332();
        sut.RemovePalindromeSub("baabb").Should().Be(2);
    }
}