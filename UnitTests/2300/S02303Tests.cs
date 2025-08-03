using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02303Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02303();
        Assert.That(sut.CalculateTax([[3, 50], [7, 10], [12, 25]], 10), Is.EqualTo(2.65));
    }

    [Test]
    public void T2()
    {
        var sut = new S02303();
        Assert.That(sut.CalculateTax([[1, 0], [4, 25], [5, 50]], 2), Is.EqualTo(0.25));
    }

    [Test]
    public void T3()
    {
        var sut = new S02303();
        Assert.That(sut.CalculateTax([[2, 50]], 0), Is.EqualTo(0));
    }
}