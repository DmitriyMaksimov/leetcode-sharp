using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01074Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01074();
        Assert.That(sut.NumSubmatrixSumTarget([[0, 1, 0], [1, 1, 1], [0, 1, 0]], 0), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01074();
        Assert.That(sut.NumSubmatrixSumTarget([[1, -1], [-1, 1]], 0), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S01074();
        Assert.That(sut.NumSubmatrixSumTarget([[904]], 0), Is.EqualTo(0));
    }
}