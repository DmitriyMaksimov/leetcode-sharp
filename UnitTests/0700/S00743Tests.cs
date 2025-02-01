using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00743Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00743();
        Assert.That(sut.NetworkDelayTime([[2, 1, 1], [2, 3, 1], [3, 4, 1]], 4, 2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00743();
        Assert.That(sut.NetworkDelayTime([[1, 2, 1]], 2, 1), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00743();
        Assert.That(sut.NetworkDelayTime([[1, 2, 1]], 2, 2), Is.EqualTo(-1));
    }
}
