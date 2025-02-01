using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00628Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00628();
        Assert.That(sut.MaximumProduct(new[] {1, 2, 3}), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00628();
        Assert.That(sut.MaximumProduct(new[] {1, 2, 3, 4}), Is.EqualTo(24));
    }

    [Test]
    public void T3()
    {
        var sut = new S00628();
        Assert.That(sut.MaximumProduct(new[] {-1, -2, -3}), Is.EqualTo(-6));
    }
}