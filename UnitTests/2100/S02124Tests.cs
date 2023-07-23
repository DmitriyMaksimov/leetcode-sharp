using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02124Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02124();
        sut.CheckString("aaabbb").Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02124();
        sut.CheckString("abab").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S02124();
        sut.CheckString("bbb").Should().BeTrue();
    }
}