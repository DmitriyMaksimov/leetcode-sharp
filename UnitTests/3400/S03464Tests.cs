using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03464))]
public class S03464Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03464();
        Assert.That(sut.MaxDistance(2, [[0, 2], [2, 0], [2, 2], [0, 0]], 4), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03464();
        Assert.That(sut.MaxDistance(2, [[0, 0], [1, 2], [2, 0], [2, 2], [2, 1]], 4), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03464();
        Assert.That(sut.MaxDistance(2, [[0, 0], [0, 1], [0, 2], [1, 2], [2, 0], [2, 2], [2, 1]], 5), Is.EqualTo(1));
    }
}