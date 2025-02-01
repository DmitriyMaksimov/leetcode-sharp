using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02124Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02124();
        Assert.That(sut.CheckString("aaabbb"), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02124();
        Assert.That(sut.CheckString("abab"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02124();
        Assert.That(sut.CheckString("bbb"), Is.True);
    }
}
