using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01833Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01833();
        Assert.That(sut.MaxIceCream(new[] {1, 3, 2, 4, 1}, 7), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01833();
        Assert.That(sut.MaxIceCream(new[] {10, 6, 8, 7, 7, 8}, 5), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01833();
        Assert.That(sut.MaxIceCream(new[] {1, 6, 3, 1, 2, 5}, 20), Is.EqualTo(6));
    }
}