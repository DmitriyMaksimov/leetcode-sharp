using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01017Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01017();
        Assert.That(sut.BaseNeg2(2), Is.EqualTo("110"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01017();
        Assert.That(sut.BaseNeg2(3), Is.EqualTo("111"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01017();
        Assert.That(sut.BaseNeg2(4), Is.EqualTo("100"));
    }
}
