using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00459Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00459();
        Assert.That(sut.RepeatedSubstringPattern("abab"), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00459();
        Assert.That(sut.RepeatedSubstringPattern("aba"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00459();
        Assert.That(sut.RepeatedSubstringPattern("abcabcabcabc"), Is.True);
    }

}
