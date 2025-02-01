using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00202Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00202();
        Assert.That(sut.IsHappy(19), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00202();
        Assert.That(sut.IsHappy(2), Is.False);
    }
}
