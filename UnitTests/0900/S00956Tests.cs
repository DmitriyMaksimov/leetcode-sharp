using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00956Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00956();
        Assert.That(sut.TallestBillboard(new[] {1, 2, 3, 6}), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00956();
        Assert.That(sut.TallestBillboard(new[] {1, 2, 3, 4, 5, 6}), Is.EqualTo(10));
    }

    [Test]
    public void T3()
    {
        var sut = new S00956();
        Assert.That(sut.TallestBillboard(new[] {1, 2}), Is.EqualTo(0));
    }
}