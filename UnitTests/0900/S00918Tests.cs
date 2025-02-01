using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00918Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00918();
        Assert.That(sut.MaxSubarraySumCircular(new[] {1, -2, 3, -2}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00918();
        Assert.That(sut.MaxSubarraySumCircular(new[] {5, -3, 5}), Is.EqualTo(10));
    }

    [Test]
    public void T3()
    {
        var sut = new S00918();
        Assert.That(sut.MaxSubarraySumCircular(new[] {-3, -2, -3}), Is.EqualTo(-2));
    }
}