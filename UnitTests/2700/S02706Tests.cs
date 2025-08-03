using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02706Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02706();
        Assert.That(sut.BuyChoco([1, 2, 2], 3), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S02706();
        Assert.That(sut.BuyChoco([3, 2, 3], 3), Is.EqualTo(3));
    }
}