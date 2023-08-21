using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00459Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00459();
        sut.RepeatedSubstringPattern("abab").Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00459();
        sut.RepeatedSubstringPattern("aba").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00459();
        sut.RepeatedSubstringPattern("abcabcabcabc").Should().BeTrue();
    }

}