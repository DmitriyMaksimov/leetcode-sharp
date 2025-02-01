using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02119Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02119();
        Assert.That(sut.IsSameAfterReversals(526), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02119();
        Assert.That(sut.IsSameAfterReversals(1800), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02119();
        Assert.That(sut.IsSameAfterReversals(0), Is.True);
    }
}
