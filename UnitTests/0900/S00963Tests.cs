using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00963Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00963();
        Assert.That(sut.MinAreaFreeRect([[1, 2], [2, 1], [1, 0], [0, 1]]), Is.EqualTo(2).Within(0.001));
    }

    [Test]
    public void T2()
    {
        var sut = new S00963();
        Assert.That(sut.MinAreaFreeRect([[0, 1], [2, 1], [1, 1], [1, 0], [2, 0]]), Is.EqualTo(1).Within(0.001));
    }

    [Test]
    public void T3()
    {
        var sut = new S00963();
        Assert.That(sut.MinAreaFreeRect([[0, 3], [1, 2], [3, 1], [1, 3], [2, 1]]), Is.EqualTo(0).Within(0.001));
    }
}
