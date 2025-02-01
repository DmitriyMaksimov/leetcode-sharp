using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03136Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03136();
        Assert.That(sut.IsValid("234Adas"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03136();
        Assert.That(sut.IsValid("b3"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S03136();
        Assert.That(sut.IsValid("a3$e"), Is.False);
    }
}
