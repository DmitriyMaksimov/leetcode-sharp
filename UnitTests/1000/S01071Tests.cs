using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01071Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01071();
        Assert.That(sut.GcdOfStrings("ABCABC", "ABC"), Is.EqualTo("ABC"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01071();
        Assert.That(sut.GcdOfStrings("ABABAB", "ABAB"), Is.EqualTo("AB"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01071();
        Assert.That(sut.GcdOfStrings("LEET", "CODE"), Is.Empty);
    }
}