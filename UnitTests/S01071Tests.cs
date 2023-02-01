using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01071Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01071();
        sut.GcdOfStrings("ABCABC", "ABC").Should().Be("ABC");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01071();
        sut.GcdOfStrings("ABABAB", "ABAB").Should().Be("AB");
    }

    [Test]
    public void T3()
    {
        var sut = new S01071();
        sut.GcdOfStrings("LEET", "CODE").Should().BeEmpty();
    }
}