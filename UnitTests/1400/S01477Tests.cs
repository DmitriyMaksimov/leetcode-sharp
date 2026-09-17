using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01477))]
public class S01477Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01477();
        Assert.That(sut.MinSumOfLengths([3, 2, 2, 4, 3], 3), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01477();
        Assert.That(sut.MinSumOfLengths([7, 3, 4, 7], 7), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01477();
        Assert.That(sut.MinSumOfLengths([4, 3, 2, 6, 2, 3, 4], 6), Is.EqualTo(-1));
    }
}