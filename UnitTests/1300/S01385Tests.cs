using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01385Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01385();
        Assert.That(sut.FindTheDistanceValue([4, 5, 8], [10, 9, 1, 8], 2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01385();
        Assert.That(sut.FindTheDistanceValue([1, 4, 2, 3], [-4, -3, 6, 10, 20, 30], 3), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01385();
        Assert.That(sut.FindTheDistanceValue([2, 1, 100, 3], [-5, -2, 10, -3, 7], 6), Is.EqualTo(1));
    }
}