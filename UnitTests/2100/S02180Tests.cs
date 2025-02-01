using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02180Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02180();
        Assert.That(sut.CountEven(4), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02180();
        Assert.That(sut.CountEven(30), Is.EqualTo(14));
    }
}