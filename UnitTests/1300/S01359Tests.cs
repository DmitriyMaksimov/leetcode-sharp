using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01359Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01359();
        sut.CountOrders(1).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01359();
        sut.CountOrders(2).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S01359();
        sut.CountOrders(3).Should().Be(90);
    }
}