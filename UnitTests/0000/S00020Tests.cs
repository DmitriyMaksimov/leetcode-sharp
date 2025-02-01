using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00020Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00020();
        Assert.That(sut.IsValid("()"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00020();
        Assert.That(sut.IsValid("()[]{}"), Is.True);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00020();
        Assert.That(sut.IsValid("(}"), Is.False);
    }
}
