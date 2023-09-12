using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01957Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01957();
        sut.MakeFancyString("leeetcode").Should().Be("leetcode");
    }

    [Test]
    public void T2()
    {
        var sut = new S01957();
        sut.MakeFancyString("aaabaaaa").Should().Be("aabaa");
    }

    [Test]
    public void T3()
    {
        var sut = new S01957();
        sut.MakeFancyString("aab").Should().Be("aab");
    }
}