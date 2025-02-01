using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01359Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01359();
        Assert.That(sut.CountOrders(1), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01359();
        Assert.That(sut.CountOrders(2), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S01359();
        Assert.That(sut.CountOrders(3), Is.EqualTo(90));
    }
}